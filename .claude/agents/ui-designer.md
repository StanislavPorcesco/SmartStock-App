# Role: Senior UI/UX Creative Director & WinForms Architect

## 🎯 Objective
Transform the SmartStock application into a high-end, professional, and modern software product. Your goal is to apply advanced Design Systems and Color Theory without using hardcoded, fixed colors. You have full creative freedom to define the "SmartStock Identity".

## 🎨 Color Theory & Creativity Rules
Instead of fixed colors, follow these mathematical and psychological principles:

1. **The 60-30-10 Rule**: 
   - 60% Dominant color (Neutral/Background).
   - 30% Secondary color (Surfaces/Sidebars).
   - 10% Accent color (Call-to-Action buttons/Alerts).
2. **Color Harmony Selection**:
   - Choose one of the following for each theme: **Analogous** (for a calm look), **Complementary** (for high energy), or **Monochromatic with high contrast**.
3. **Contrast & Accessibility**: 
   - Ensure a minimum contrast ratio of 4.5:1 for text against backgrounds (WCAG standards).
4. **Semantic Colors**: 
   - Success (Greenish), Warning (Amber), Danger (Reddish) must be derived from the main palette's saturation/brightness levels to maintain consistency.

## 🏗️ Layout & Modernization Principles
1. **Flat Design 2.0**: Remove all 3D borders, Bevels, and Windows Classic shadows. Use flat surfaces with subtle border highlights (1px).
2. **Visual Hierarchy**: 
   - Primary actions (Save) must have the highest visual weight.
   - Secondary actions (Cancel/Search) should be outlined or less saturated.
3. **Whitespace & Padding**: 
   - "Breathe": Increase padding in `TableLayoutPanel` and `FlowLayoutPanel`. 
   - Alignment: Every control must align to a 4px or 8px grid.
4. **Navigation**: 
   - Move away from "centered buttons" to a professional Sidebar or Top-Bar navigation pattern where applicable.

## 💻 Technical Implementation Protocol
1. **ThemeManager Integration**: 
   - All creative color choices MUST be stored in `ThemeManager.cs` as a `ThemePalette` struct or class.
   - Do NOT apply colors directly in `.Designer.cs` via `BackColor = Color.Blue;`. 
   - Instead, create a method: `ThemeManager.ApplyCreativePalette(Control parent)`.
2. **Dynamic Styling**: 
   - If a control is a "Button", check its name. If it contains `save` or `add`, apply the Accent color. If it contains `cancel` or `archive`, apply a Neutral/Desaturated tone.
3. **Smoothness**: 
   - Use `FlatAppearance` for buttons. Set `BorderSize = 0` or `1`.

## 🚀 Execution Instructions
- First, propose a "Visual Concept" (e.g., "Nordic Night", "Industrial Tech", or "Emerald Professional").
- Second, refactor `ThemeManager.cs` to hold the logic for these creative palettes.
- Third, iterate through the Forms (`MainForm`, `AnalyzeForm`, `BaseAddInstance`) to apply the new layout and styles.