# Critical Design Patterns

## Repository Pattern — ClearChanges() Guard

**Problem:** Multiple repositories share a single `SmartStockContext`. If one `SaveAsync` fails (constraint violation), the failed entity stays in `Added` state. Next `SaveAsync` on another repo inherits the poisoned context, retries the stuck INSERT, rolls back silently.

**Solution:** Call `repository.ClearChanges()` in every persistence `catch` block:
```csharp
catch
{
    _econometricModelRepository.ClearChanges(); // detaches stuck entities
}
```

**Implementation:** `IRepository<T>.ClearChanges()` → `_context.ChangeTracker.Clear()`.

**Rule:** Any time multiple sequential `SaveAsync` calls share a single `DbContext`, always `ClearChanges()` on failure.

---

## BindingList — DataSource Null Trap

**Pattern:** `ClearControls()` sets `grid.DataSource = null`. If user then adds items to `_list` (BindingList), `ListChanged` fires but grid has no source → rows never render.

**Fix:** Always call `BindCartGrid()` after any list mutation, not just initial load:
```csharp
private void BindCartGrid()
{
    sales_dgv.DataSource = null;  // force refresh
    sales_dgv.DataSource = _saleItemsList;  // rebind
}
```

**Rule:** After *any* cart/list edit (add, remove, update), call `BindCartGrid()` or equivalent rebind.

---

## Deferred Credential Resolution

**Problem:** Constructor throws if API key empty → form load catches exception → fallback provider installed permanently. User can't recover even after saving the key.

**Solution:** Constructor doesn't throw. Key resolved at call-time:
```csharp
private string ResolveApiKey()
{
    if (!string.IsNullOrWhiteSpace(_constructorApiKey)) return _constructorApiKey;
    if (!string.IsNullOrWhiteSpace(SettingsManager.Current.DeepSeekApiKey))
        return SettingsManager.Current.DeepSeekApiKey;
    return Environment.GetEnvironmentVariable("DEEPSEEK_API_KEY") ?? string.Empty;
}
```

Applied in: `DeepSeekAiProvider`, `ExternalFactorsFetchService`, `WeeklyReportService` (all call-time resolution).

**Rule:** Never bake infrastructure credentials into constructors. Resolve at point of use.

---

## Bootstrap Sequence — PathsManager

**Problem:** `appSettings.json` can't store its own path. Circular dependency.

**Solution:** `Resources/paths.cfg` (fixed location) bootstraps everything:
```
SettingsFilePath=<path to appSettings.json>
DatabasePath=<path to SmartStock.db>
```

**Load order:**
1. `PathsManager.Load()` — reads paths.cfg, fills properties, falls back to `<exe>/Resources/` defaults.
2. `SettingsManager.Load()` — uses `PathsManager.SettingsFilePath` (computed property).
3. `db.Database.Migrate()` — `SmartStockContext.OnConfiguring` uses `PathsManager.DatabasePath`.
4. `ReportScheduler.Start()` and `ExternalFactorsScheduler.Start()` (deferred 2 min).

**Rule:** Call `PathsManager.Load()` as the very first operation in `Program.Main()`.

---

## Filter Controls — Tooltip Pattern

**Rule:** Never use form-level tooltips. Always attach to specific label:
```csharp
ToolTipHelp.AddToolTip(product_name_lbl, "Filter by product name (partial match).");
```

**Why:** Tooltip appears exactly where the user is looking. Form-level tooltips are generic and unhelpful.

Applied in: All 8 `Filter*.cs` controls in `LoadUI()`.

---

## OTP TextBox Styling

**Tag:** `"otp"` on each TextBox.

**Applied by ThemeManager:**
- `BackColor = theme.SurfaceHover` (contrast with base panel)
- `ForeColor = theme.Accent` (amber text, high contrast)
- `BorderStyle = FixedSingle` (1px border for visual separation)
- `Font = Segoe UI, 28.2pt, Bold` (large, readable)
- `MaxLength = 1` (single digit)
- `TextAlign = HorizontalAlignment.Center` (centered in box)

**Parent panel:** Tag="base" (Background color, not Surface) for contrast with OTP boxes.

---

## TableLayoutPanel with Percent Columns

**Pattern:** Use `SizeType.Percent` for responsive layouts that scale with window:
```csharp
tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.67F));
tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.67F));
// ... 6 columns = 100% total
```

**Applied in:**
- OTP digit boxes (MailConfirmation): 6 equal columns, `Dock=Fill` table, `Anchor=None` on textboxes (centers in cells).
- Login form: 2-column root layout (hero + form).
- MenuForm: 2-column root (320px sidebar + fill content).

**Rule:** Never use `AutoSize` + `Dock=Top` together when children include `Dock=Fill` and you need fixed-height scrolling. Use explicit `Size.Height`.

---

## Scheduler Deferred Startup

**Pattern:** `ReportScheduler.Start()` and `ExternalFactorsScheduler.Start()` called in `Program.cs` after full app load.

`ExternalFactorsScheduler` defers its first check 2 minutes to allow DB setup.

Both stopped in `Application.ApplicationExit` event handler.

**Rule:** Always clean up background threads on app exit.

---

## Menu Button Sidebar Layout

**Pattern:** `menu_buttons_pnl.Controls` added in reverse order, each with `Dock=DockStyle.Top`:
```csharp
settings_btn.Dock = DockStyle.Top;   // added last, appears at top
analyze_btn.Dock = DockStyle.Top;    // second to last
modify_btn.Dock = DockStyle.Top;
search_btn.Dock = DockStyle.Top;
add_btn.Dock = DockStyle.Top;        // added first, appears at bottom
```

Higher `Controls.Add` index = higher position on screen.

**Left border amber strip:** Positioned inside `menu_buttons_pnl` at `Point(0, button.Location.Y)`.

---

## Theme Manager — Control Tags

**Critical:** Use Tags, not hardcoded BackColor/ForeColor.

### Panel Tags
| Tag | BackColor |
|---|---|
| `"base"` | Background (dark: #0E1420, light: #FAFAF7) |
| `"hero"` | Surface (dark: #161D2E, light: #F0EFE9) |
| `"card"` | Surface + styled border (elevated appearance) |
| `"divider"` | Border (dark: #252E47, light: #D4D1C5) |
| `"workplace"` | Background (main work area) |

### Label Tags
| Tag | ForeColor |
|---|---|
| `"accent"` | Accent (dark: #F5B547 amber, light: #0D7D6B teal) |
| `"muted"` | TextSecondary (dark: #94A0B8, light: #5C615E) |
| `"hero-muted"` | TextSecondary (variant) |

### Button Tags
| Tag | Style |
|---|---|
| `"cta"` | Solid accent bg + OnAccent text (primary action) |
| `"ghost"` | Transparent + TextSecondary text (secondary) |
| `"outlined"` | Transparent + border (tertiary) |
| `"menu"` | Transparent + hover color (sidebar nav) |
| `"clean_icon"` | Transparent, no border (icon-only) |

### TextBox Tags
| Tag | Effect |
|---|---|
| `"flat"` | `BorderStyle = None` (no 3D border) |
| `"otp"` | SurfaceHover BG + Accent text + border (digit entry) |

### Icon Tags
| Tag | IconColor |
|---|---|
| `"accent-icon"` | Accent (amber/teal) |
| `"muted-icon"` | TextSecondary |

### Special Rules
- `Tag = "range_lock"` on `NumericUpDown` prevents ThemeManager from overwriting `Maximum = 9999999999`.
- `Tag = "clean_icon"` on `IconButton` sets `BorderSize = 0`, `MouseOverBackColor = Transparent`, `IconColor = TextPrimary`.

**Rule:** All new controls must have a semantic Tag. No hardcoded colors in Designer.

---

## DeepSeek Prompt Engineering

**Format:** Plain text (not JSON) prompt, structured but concise.

**Template:**
```
Product: {name}
Current stock: {stock} {unit} | Safety stock: {safetyStock} | Gap: {±gap}
Demand — avg: {avg}, peak: {peak}, trend: {trendDescription}
Upcoming forecast ({N} days): {date: demand, ...}
Active external factors: {label (±impact), ...}

Recommend restock quantity and priority. State the specific risk or opportunity driving your decision,
then give a precise action. Do not repeat the numbers above — explain what they mean.
```

**System message enforces:**
- 3–5 sentence max on `reasoning`.
- Lead with key risk/opportunity.
- Give specific, actionable recommendation.
- Never repeat input numbers verbatim.
- No preamble, no filler phrases.

**Why:** Old JSON + verbose system message produced outputs that restated all input data before concluding. New format forces conclusion-first with hard sentence cap.

Applied in: `PromptBuilder.BuildInventoryPrompt()`, `DeepSeekAiProvider.BuildRequest()`.
