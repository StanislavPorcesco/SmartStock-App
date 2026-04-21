
using FontAwesome.Sharp;

namespace SmartStock.Classes.Utils
{
    using Microsoft.Windows.Themes;
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Drawing.Drawing2D;
    using System.Net.NetworkInformation;
    using System.Reflection;
    using System.Windows.Documents;
    using System.Windows.Forms;

    public static class ThemeManager
    {
        // Eveniment la care se vor abona toate Form-urile pentru update live
        public static event Action OnThemeChanged;

        public static string CurrentThemeName { get; private set; } = "Dark";

        // "Midnight Cobalt" — Analogous blue/indigo base + amber accent (Concept 1).
        // "Light" — kept as a compatible warm-neutral fallback for the theme toggle.
        public static readonly Dictionary<string, ThemePalette> Themes = new Dictionary<string, ThemePalette>
        {
            { "Dark", new ThemePalette
                {
                    Background    = Color.FromArgb(14, 20, 32),     // #0E1420 — app bg (60%)
                    Surface       = Color.FromArgb(22, 29, 46),     // #161D2E — cards/sidebars (30%)
                    SurfaceHover  = Color.FromArgb(30, 39, 64),     // #1E2740 — hover/active
                    Accent        = Color.FromArgb(245, 181, 71),   // #F5B547 — amber CTA (10%)
                    AccentHover   = Color.FromArgb(255, 200, 102),  // #FFC866
                    OnAccent      = Color.FromArgb(14, 20, 32),     // dark text on amber
                    TextPrimary   = Color.FromArgb(230, 235, 245),  // #E6EBF5
                    TextSecondary = Color.FromArgb(148, 160, 184),  // #94A0B8
                    Border        = Color.FromArgb(37, 46, 71),     // #252E47
                    Success       = Color.FromArgb(74, 222, 128),   // #4ADE80
                    Warning       = Color.FromArgb(251, 191, 36),   // #FBBF24
                    Danger        = Color.FromArgb(248, 113, 113)   // #F87171
                }
            },
            { "Light", new ThemePalette
                {
                    Background    = Color.FromArgb(250, 250, 247),
                    Surface       = Color.FromArgb(240, 239, 233),
                    SurfaceHover  = Color.FromArgb(230, 228, 219),
                    Accent        = Color.FromArgb(13, 125, 107),
                    AccentHover   = Color.FromArgb(15, 160, 136),
                    OnAccent      = Color.FromArgb(250, 250, 247),
                    TextPrimary   = Color.FromArgb(26, 29, 26),
                    TextSecondary = Color.FromArgb(92, 97, 94),
                    Border        = Color.FromArgb(212, 209, 197),
                    Success       = Color.FromArgb(46, 139, 87),
                    Warning       = Color.FromArgb(184, 119, 10),
                    Danger        = Color.FromArgb(180, 58, 58)
                }
            }
        };

        public static void SetTheme(string themeName)
        {
            if (Themes.ContainsKey(themeName))
            {
                CurrentThemeName = themeName;
                // Notificăm toate ferestrele abonate să se redeseneze
                OnThemeChanged?.Invoke();
            }
        }

        public static void Apply(Control parent)
        {
            if (!Themes.TryGetValue(CurrentThemeName, out var theme)) return;

            // Dacă controlul este o Formă, îi schimbăm fundalul principal
            if (parent is Form frm)
            {
                frm.BackColor = theme.Background;
                frm.ForeColor = theme.TextPrimary;
            }

            foreach (Control c in parent.Controls)
            {
                // Aplicăm culorile în funcție de tipul controlului
                ApplyStyleToControl(c, theme);

                // Dacă controlul are alți copii (Panel, GroupBox etc.), intrăm recursiv
                if (c.HasChildren)
                {
                    Apply(c);
                }
            }
        }

        private static void ApplyStyleToControl(Control c, ThemePalette theme)
        {
            c.ForeColor = theme.Text;

            // Personalizare logică pe tipuri de controale
            switch (c)
            {
                case TableLayoutPanel flp:
                    if (flp.Tag != null && flp.Tag.ToString() == "workplace")
                        flp.BackColor = theme.LightColor;
                    break;
                case Button btn:
                    if (btn is IconButton icn)
                    {
                        icn.IconColor = theme.Text;
                    }
                    btn.FlatStyle = FlatStyle.Flat;
                    if ("cta".Equals(btn.Tag))
                    {
                        btn.BackColor = theme.Accent;
                        btn.ForeColor = theme.OnAccent;
                        btn.FlatAppearance.BorderSize = 0;
                        btn.FlatAppearance.MouseOverBackColor = theme.AccentHover;
                        btn.FlatAppearance.MouseDownBackColor = theme.Accent;
                        if (btn is IconButton ctaIcn) ctaIcn.IconColor = theme.OnAccent;
                    }
                    else if ("ghost".Equals(btn.Tag))
                    {
                        btn.BackColor = Color.Transparent;
                        btn.ForeColor = theme.TextSecondary;
                        btn.FlatAppearance.BorderSize = 0;
                        btn.FlatAppearance.MouseOverBackColor = theme.SurfaceHover;
                        btn.FlatAppearance.MouseDownBackColor = theme.SurfaceHover;
                        if (btn is IconButton ghostIcn) ghostIcn.IconColor = theme.TextSecondary;
                    }
                    else if ("outlined".Equals(btn.Tag))
                    {
                        btn.BackColor = Color.Transparent;
                        btn.ForeColor = theme.TextPrimary;
                        btn.FlatAppearance.BorderSize = 1;
                        btn.FlatAppearance.BorderColor = theme.Border;
                        btn.FlatAppearance.MouseOverBackColor = theme.Surface;
                        btn.FlatAppearance.MouseDownBackColor = theme.SurfaceHover;
                    }
                    else if ("titlebar_buttons".Equals(btn.Tag))
                    {
                        btn.FlatAppearance.BorderSize = 0;
                        btn.BackColor = Color.Transparent;
                        btn.FlatAppearance.MouseOverBackColor = theme.Surface;
                        btn.FlatAppearance.MouseDownBackColor = theme.SurfaceHover;
                    }
                    else if ("menu".Equals(btn.Tag) || "title".Equals(btn.Tag))
                    {
                        btn.BackColor = Color.Transparent;
                        btn.FlatAppearance.BorderSize = 0;
                        //btn.FlatAppearance.MouseOverBackColor = theme.HoverColor;
                        btn.FlatAppearance.MouseOverBackColor = theme.Surface;
                        btn.FlatAppearance.MouseDownBackColor = theme.SurfaceHover;
                    }
                    else if ("clean_icon".Equals(btn.Tag))
                    {
                        btn.BackColor = Color.Transparent;
                        btn.FlatAppearance.BorderSize = 0;
                        btn.FlatAppearance.MouseOverBackColor = Color.Transparent;
                        btn.FlatAppearance.MouseDownBackColor = Color.Transparent;
                        if (btn is IconButton cleanIcn)
                            cleanIcn.IconColor = theme.Text;
                    }
                    else
                    {
                        btn.BackColor = theme.LightColor;
                        btn.FlatAppearance.BorderSize = 1;
                        btn.FlatAppearance.BorderColor = theme.Border;
                        btn.FlatAppearance.MouseOverBackColor = theme.HoverColor;
                    }
                    break;

                case TextBox txt:
                    txt.BackColor = theme.LightColor;
                    txt.ForeColor = theme.TextPrimary;
                    if ("flat".Equals(txt.Tag))
                    {
                        txt.BorderStyle = BorderStyle.None;
                    }
                    else if ("otp".Equals(txt.Tag))
                    {
                        // OTP digit boxes: SurfaceHover bg + amber digit text + single border
                        txt.BackColor   = theme.SurfaceHover;
                        txt.ForeColor   = theme.Accent;
                        txt.BorderStyle = BorderStyle.FixedSingle;
                    }
                    else
                    {
                        txt.BorderStyle = BorderStyle.Fixed3D;
                    }
                    break;

                case Label lbl:
                    if ("workplace".Equals(lbl.Tag))
                        lbl.BackColor = theme.LightColor;
                    else if ("hero".Equals(lbl.Tag))
                        lbl.BackColor = theme.Surface;
                    else
                        lbl.BackColor = Color.Transparent;

                    if ("muted".Equals(lbl.Tag) || "hero-muted".Equals(lbl.Tag))
                        lbl.ForeColor = theme.TextSecondary;
                    else if ("accent".Equals(lbl.Tag))
                        lbl.ForeColor = theme.Accent;
                    else
                        lbl.ForeColor = theme.Text;
                    break;

                case DataGridView dgv:
                    Font gridFont = new Font("Segoe UI", 10, FontStyle.Regular);
                    Font headerFont = new Font("Segoe UI", 10, FontStyle.Bold);
                    // 1. Fundalul general al controlului (zona fără celule)
                    dgv.BackgroundColor = theme.Surface;
                    dgv.GridColor = theme.DarkColor; // Culoarea liniilor de demarcație

                    // 2. Dezactivăm stilul Windows pentru a permite culori custom pe Headere
                    dgv.EnableHeadersVisualStyles = false;

                    // 3. Stilul Celulelor (Date)
                    dgv.DefaultCellStyle.BackColor = theme.LightColor;
                    dgv.DefaultCellStyle.ForeColor = theme.Text;
                    dgv.DefaultCellStyle.SelectionBackColor = theme.DarkColor; // Recomandat pentru contrast
                    dgv.DefaultCellStyle.SelectionForeColor = theme.Text;
                    dgv.DefaultCellStyle.Font = gridFont;

                    // Forțează selecția rândului întreg la orice click pe o celulă
                    dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dgv.MultiSelect = false;
                    dgv.StandardTab = true;
                    dgv.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;

                    // 4. Stilul Headerelor de Coloane
                    dgv.ColumnHeadersDefaultCellStyle.BackColor = theme.Surface;
                    dgv.ColumnHeadersDefaultCellStyle.ForeColor = theme.Text;
                    dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = theme.Surface; // Evită schimbarea culorii la click
                    dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
                    dgv.ColumnHeadersDefaultCellStyle.Font = headerFont;

                    // 5. Stilul Headerelor de Rânduri (partea stângă)
                    dgv.RowHeadersDefaultCellStyle.BackColor = theme.DarkColor;
                    dgv.RowHeadersDefaultCellStyle.ForeColor = theme.Text;
                    dgv.RowHeadersDefaultCellStyle.SelectionBackColor = theme.DarkColor;
                    dgv.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

                    typeof(DataGridView).InvokeMember("DoubleBuffered",
                        BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty,
                        null, dgv, new object[] { true });
                    dgv.RowPostPaint -= Dgv_RowPostPaint;
                    dgv.RowPostPaint += Dgv_RowPostPaint;

                    dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                    dgv.Resize -= Dgv_Resize;
                    dgv.Resize += Dgv_Resize;
                    dgv.Scroll -= (s, ev) => dgv.Invalidate();
                    dgv.Scroll += (s, ev) => dgv.Invalidate();

                    dgv.DataBindingComplete -= Dgv_DataBindingComplete;
                    dgv.DataBindingComplete += Dgv_DataBindingComplete;

                    AdjustGridAutoSize(dgv);

                    AdjustGridAutoSize(dgv);

                    break;
                case ComboBox combo:
                    combo.FlatStyle = FlatStyle.Flat; 
                 
                    combo.BackColor = theme.LightColor;
                    combo.ForeColor = theme.Text;
                    combo.DisableMouseWheelScroll();

                    // IMPORTANT: Set AutoCompleteSource BEFORE AutoCompleteMode
                    // to avoid NotSupportedException with DropDownList style
                    combo.AutoCompleteSource = AutoCompleteSource.ListItems;
                    combo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    break;
                case Panel pnl:
                    var ptag = pnl.Tag?.ToString();
                    switch (ptag)
                    {
                        case "hero":
                            pnl.BackColor = theme.Surface;
                            break;
                        case "workplace":
                        case "input":
                        case "card":
                            pnl.BackColor = theme.Surface;
                            break;
                        case "main_card":
                            pnl.BackColor = theme.Surface;
                            RoundBorders(pnl);
                            break;
                        case "accent":
                            pnl.BackColor = theme.Accent;
                            break;
                        case "divider":
                            pnl.BackColor = theme.Border;
                            break;
                        case "menu":
                        case "base":
                        default:
                            pnl.BackColor = theme.Background;
                            break;
                    }
                    break;
                case GroupBox grp:
                    grp.BackColor = theme.DarkColor;
                    break;
                 case CheckBox chk:
                    chk.BackColor = theme.LightColor;
                    chk.ForeColor = theme.TextSecondary;
                    break;
                case IconPictureBox pic:
                    pic.BackColor = Color.Transparent;
                    pic.IconColor = theme.Text;
                    var picTag = pic.Tag?.ToString();
                    if (picTag == "menu") pic.BackColor = theme.Background;
                    else if (picTag == "workplace" || picTag == "input") {
                        pic.BackColor = theme.Surface;
                        pic.IconSize = 30;
                    } 
                    else if (picTag == "hero") pic.BackColor = theme.Surface;
                    if (picTag == "accent-icon") pic.IconColor = theme.Accent;
                    else if (picTag == "muted-icon" || picTag == "input") pic.IconColor = theme.TextSecondary;
                    break;
                case DateTimePicker date:
                    date.Format = DateTimePickerFormat.Custom;
                    date.CalendarMonthBackground = theme.DarkColor;
                    date.CalendarTitleBackColor = theme.LightColor;
                    date.CalendarTitleForeColor = theme.Text;
                    date.CalendarTrailingForeColor = theme.Text;
                    date.BackColor = theme.LightColor;
                    date.ForeColor = theme.Text;
                    break;
                case RadioButton radio:
                    radio.BackColor = theme.LightColor;
                    radio.ForeColor = theme.TextSecondary;
                    break;
                case NumericUpDown num:
                    num.BackColor = theme.LightColor;
                    num.ForeColor = theme.Text;
                    if (!"range_lock".Equals(num.Tag))
                        num.Maximum = 9999999999;
                    break;
                case CheckedListBox ck:
                    ck.BackColor = theme.LightColor;
                    ck.ForeColor = theme.Text;
                    break;
                case TrackBar tr:
                    tr.BackColor = theme.Surface;
                    break;
                case RichTextBox rtb:
                    if ("insights".Equals(rtb.Tag))
                    {
                        rtb.BackColor = theme.Surface;
                        rtb.ForeColor = theme.TextSecondary;
                    }
                    else
                    {
                        rtb.BackColor = theme.LightColor;
                        rtb.ForeColor = theme.Text;
                    }
                    break;
                case LiveChartsCore.SkiaSharpView.WinForms.CartesianChart chart:
                    chart.BackColor = theme.LightColor;
                    chart.ForeColor = theme.Text;
                    break;
                default:
                    // Unknown controls inherit parent bg — never hard-force black.
                    break;
            }
        }

        public class ThemePalette
        {
            // Creative palette (60-30-10, WCAG-compliant)
            public Color Background    { get; set; }   // 60% — app bg
            public Color Surface       { get; set; }   // 30% — sidebars/cards/inputs
            public Color SurfaceHover  { get; set; }
            public Color Accent        { get; set; }   // 10% — CTA
            public Color AccentHover   { get; set; }
            public Color OnAccent      { get; set; }   // text/icon color on Accent bg
            public Color TextPrimary   { get; set; }
            public Color TextSecondary { get; set; }
            public Color Border        { get; set; }
            public Color Success       { get; set; }
            public Color Warning       { get; set; }
            public Color Danger        { get; set; }

            // Legacy aliases — keep existing call sites working without changes.
            public Color LightColor => Surface;
            public Color DarkColor  => Background;
            public Color HoverColor => SurfaceHover;
            public Color Text       => TextPrimary;
        }

        public static ThemePalette GetCurrentPalette()
        {
            return Themes[CurrentThemeName];
        }

        /// <summary>
        /// Applies the currently selected creative palette recursively.
        /// Alias of <see cref="Apply(Control)"/> — use this at call sites that
        /// want the intent ("apply our design system") to be explicit.
        /// </summary>
        public static void ApplyCreativePalette(Control parent) => Apply(parent);

        public static void ApplyThemeToParentForm()
        {
            try
            {
                foreach (Form form in Application.OpenForms)
                {
                    if (form.Name == "MenuForm" || form.GetType().Name == "MenuForm")
                    {
                        ThemeManager.Apply(form);
                        form.Invalidate(true);
                        form.Update();
                        form.Refresh();

                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error updating parent form: {ex.Message}");
            }
        }
        private static void Dgv_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var dgv = sender as DataGridView;
            if (dgv == null) return;

            if ((e.State & DataGridViewElementStates.Selected) == DataGridViewElementStates.Selected)
            {
                using (Pen pen = new Pen(ThemeManager.GetCurrentPalette().Text, 2))
                {
                    int rowWidth = dgv.DisplayRectangle.Width;
                    int left = dgv.RowHeadersVisible ? dgv.RowHeadersWidth : 0;
                    int right = left + rowWidth;
                    int top = e.RowBounds.Top;
                    int bottom = e.RowBounds.Bottom - 1;
                    e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;

                    e.Graphics.DrawLine(pen, left, top, right, top);
                    e.Graphics.DrawLine(pen, left, bottom, right, bottom);
                }
            }
        }
        private static void Dgv_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (sender is DataGridView dgv)
            {
                AdjustGridAutoSize(dgv);
            }
        }

        private static void AdjustGridAutoSize(DataGridView dgv)
        {
            if (dgv.Columns.Count == 0 || dgv.ClientRectangle.Width == 0) return;
            int totalPreferredWidth = dgv.Columns.Cast<DataGridViewColumn>()
                .Sum(c => c.GetPreferredWidth(DataGridViewAutoSizeColumnMode.ColumnHeader, true));

            var targetMode = (totalPreferredWidth < dgv.ClientRectangle.Width)
                ? DataGridViewAutoSizeColumnsMode.Fill
                : DataGridViewAutoSizeColumnsMode.DisplayedCells;

            if (dgv.AutoSizeColumnsMode != targetMode)
            {
                dgv.AutoSizeColumnsMode = targetMode;
            }
        }
        private static void Dgv_Resize(object sender, EventArgs e)
        {
            if (sender is DataGridView dgv)
            {
                AdjustGridAutoSize(dgv);
            }
        }

        private static void RoundBorders(Control c)
        {
            if (c is Panel)
            {
                ApplyRoundRegion(c);
                c.Resize -= RoundedPanel_Resize;
                c.Resize += RoundedPanel_Resize;
            }
        }

        private static void RoundedPanel_Resize(object sender, EventArgs e)
        {
            if (sender is Control c)
                ApplyRoundRegion(c);
        }

        private static void ApplyRoundRegion(Control c)
        {
            int radius = 20;
            GraphicsPath path = new GraphicsPath();
            // Use Width-1 / Height-1 to stay within GDI+ visible bounds
            Rectangle rect = new Rectangle(0, 0, c.Width - 1, c.Height - 1);

            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);                          // Top-left
            path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);             // Top-right
            path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90); // Bottom-right
            path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);             // Bottom-left
            path.CloseFigure();

            c.Region = new Region(path);
        }
    }
}
