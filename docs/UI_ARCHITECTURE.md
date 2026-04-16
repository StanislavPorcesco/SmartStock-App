# UI Architecture Patterns

## AnalyzeForm — Contextual Panel Visibility & Reparenting

### NLQ Mode (index 3: Natural Language Query)
When selected, `LoadDynamicParameterControl` hides:
- `label1` + `target_subject_cb`
- `label2` + `start_date_dtp` + `end_date_dtp`

These are irrelevant for free-text SQL queries; restored on other analysis types.

### Shared Status Bar (`panel3`) — Runtime Reparenting
Single `panel3` (status label + progress bar) reparents at runtime between `groupBox1` (analysis) and `query_results_gb` (NLQ) to avoid state duplication:

```csharp
var targetBox = isNlq ? (Control)query_results_gb : groupBox1;
if (panel3.Parent != targetBox)
{
    panel3.Parent?.Controls.Remove(panel3);
    targetBox.Controls.Add(panel3);
}
```

**Padding rule:** `query_results_gb.Padding = new Padding(10, 10, 10, 3)` (bottom = 3 px, not 10) to match `groupBox1`'s visual baseline.

---

## ModifySale — In-Memory Cart Pattern

### Flow
1. Load existing sale or start empty → bind `_saleItemsList` (BindingList<SaleDetails>) to grid.
2. `add_to_cart_btn_Click`: Validate inputs → lookup product → check stock → add/update in list.
3. `remove_from_cart_btn_Click`: Find all by ProductId → remove → rebind.
4. `PerformSave`: Compute `TotalAmount = _saleItemsList.Sum(d => d.LineTotal)` → call `AddSaleWithDetailsAsync`.

### Key Rules
- **Always rebind grid after mutation:** `BindCartGrid()` sets `DataSource = null` then reassigns (forces refresh).
- **[NotMapped] ProductName:** Display-only field; set from lookup or fallback to "Product #{Id}".
- **DataSource null trap:** If `ClearControls()` sets DataSource=null but user adds items to the list, `ListChanged` fires with no grid attached → silent failure. Always call `BindCartGrid()` after every edit.

---

## SettingsForm — Scrollable Layout

### Structure
```
Form (Padding=30)
├── apply_pnl     (Dock=Bottom, height=53) ← fixed, always visible
└── base_pnl      (Dock=Fill, AutoScroll=true, Padding=10)
    └── settings_table  (Dock=Top, not Fill) ← scrollable content
```

### Why Dock=Top (not Fill) on settings_table
- `Dock=Fill` resizes to fit parent → no overflow → AutoScroll never activates.
- `Anchor=Top|Left` with hardcoded width leaves gaps on wide windows.
- `Dock=Top` stretches width, keeps fixed height → overflow triggers scrollbar.

### Why apply_pnl at Form level
`apply_pnl` inside `base_pnl` with `Dock=Bottom` scrolls away. Moving it to Form child (`Dock=Bottom`) pins it to window bottom.

---

## AutoScroll + AutoSize Conflict

### Problem
`ModifySale.base_pnl` had `AutoScroll=true` but scrollbars never appeared despite overflow.

### Root Cause
`add_instance_pnl` + `tableLayoutPanel4` both had `AutoSize=true` + `AutoSizeMode=GrowAndShrink`. With `Dock=Top`, WinForms computes height from children's preferred size. Children with `Dock=Fill` contribute 0 → chain collapsed to near-0 height → no overflow.

### Fix
Remove `AutoSize` from both panels. Keep `Dock=Top` + explicit `Size.Height` from Designer. Explicit height is used directly; overflow triggers `AutoScroll`.

**Rule:** Never combine `AutoSize=true` + `Dock=Top` with `Dock=Fill` children when you need fixed-height overflow scrolling. Use explicit `Size.Height` instead.

---

## Filter UserControls — Tooltip Pattern

All `Filter*.cs` use `ToolTipHelp.AddToolTip(label, text)` per-label in `LoadUI()`:

```csharp
ToolTipHelp.AddToolTip(product_name_lbl, "Filter products by product name (partial match).");
ToolTipHelp.AddToolTip(category_lbl,     "Filter products by category...");
```

**Rule:** Never `AddToolTip(this, ...)` (form-level). Always attach to specific label so tooltip appears exactly where the user looks.

---

## MenuForm — Modern 2026 Redesign

### Layout
Root `TableLayoutPanel` (2 cols: 320px sidebar + fill content):
- **Left:** `menu_pnl` (sidebar)
  - Brand header: logo + "Smart Stock" (amber accent)
  - Nav buttons: Add/Modify, Search, Analyze, Settings (Tag="menu")
  - User card footer: avatar + name + role (Tag="card")
- **Right:** `right_host`
  - Titlebar: section icon + title (64px height)
  - Desktop area: child forms (Dock=Fill)
  - Bottom bar: status + version (32px)

### Code-Behind
- `PopulateUserCard()`: Pull `SessionManager.CurrentUser` into `user_name_lbl`/`user_role_lbl`/`status_lbl`.
- `ActivateButton()`: Left border amber strip position now inside `menu_buttons_pnl` (not two-level offset).
- `HandleThemeUpdate()`: Reapply theme to active child form on palette change.

---

## Console Window Suppression

Three layers to prevent console window on VS launch:
1. **`FreeConsole()` P/Invoke** in `Program.Main()` — detaches process from VS-attached console.
2. **`Console.SetOut/SetError(TextWriter.Null)`** — redirect residual `Console.Write*` to null.
3. **`launchSettings.json`** — `"console": "internalConsole"` routes debug output to VS Output pane.
4. **`.csproj`** — `WinExe` sets PE subsystem flag for standalone execution.
