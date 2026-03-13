
using FontAwesome.Sharp;

namespace SmartStock.Classes.Utils
{
    using Microsoft.Windows.Themes;
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Reflection;
    using System.Windows.Documents;
    using System.Windows.Forms;

    public static class ThemeManager
    {
        // Eveniment la care se vor abona toate Form-urile pentru update live
        public static event Action OnThemeChanged;

        public static string CurrentThemeName { get; private set; } = "Light";

        // Definiția paletelor de culori
        public static readonly Dictionary<string, ThemePalette> Themes = new Dictionary<string, ThemePalette>
        {
            { "Dark", new ThemePalette { 
                DarkColor = Color.FromArgb(54,54,54),
                LightColor = Color.FromArgb(64,64,64),
                HoverColor = Color.FromArgb(74,74,74),
                Accent = Color.White,
                Text = Color.WhiteSmoke
            }},
            { "Light", new ThemePalette {
                DarkColor = Color.FromArgb(240, 240, 240),
                LightColor = Color.White,
                HoverColor = Color.FromArgb(220, 220, 220),
                Accent = Color.FromArgb(40,40,40),
                Text = Color.FromArgb(40,40,40)
             }}
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
                frm.BackColor = theme.LightColor;
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
                    if(btn is IconButton icn)
                    {
                        icn.IconColor = theme.Text;
                    }
                    btn.FlatAppearance.MouseOverBackColor = theme.HoverColor;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.FlatStyle = FlatStyle.Flat;
                    if ("menu".Equals(btn.Tag) || "title".Equals(btn.Tag))
                    {
                        btn.BackColor = Color.Transparent;
                    }
                    else
                    {
                        btn.BackColor = theme.LightColor;
                        btn.FlatStyle = FlatStyle.Flat;
                        btn.FlatAppearance.BorderSize = 1;
                    }                  
                    break;

                case TextBox txt:
                    txt.BackColor = theme.LightColor;
                    txt.BorderStyle = BorderStyle.Fixed3D;
                    break;

                case Label lbl:
                    if (lbl.Tag != null && lbl.Tag.ToString() == "workplace")
                        lbl.BackColor = theme.LightColor;
                    else
                        lbl.BackColor = Color.Transparent;
                    break;

                case DataGridView dgv:
                    Font gridFont = new Font("Segoe UI", 10, FontStyle.Regular);
                    Font headerFont = new Font("Segoe UI", 10, FontStyle.Bold);
                    // 1. Fundalul general al controlului (zona fără celule)
                    dgv.BackgroundColor = theme.DarkColor;
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
                    dgv.ColumnHeadersDefaultCellStyle.BackColor = theme.DarkColor;
                    dgv.ColumnHeadersDefaultCellStyle.ForeColor = theme.Text;
                    dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = theme.DarkColor; // Evită schimbarea culorii la click
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
                    break;
                case Panel pnl:
                    if(pnl.Tag != null && pnl.Tag.ToString() == "menu")
                    {
                        pnl.BackColor = theme.DarkColor;
                    }
                    else if(pnl.Tag != null && pnl.Tag.ToString() == "base")
                        pnl.BackColor = theme.DarkColor;
                    else if (pnl.Tag != null && pnl.Tag.ToString() == "accent")
                        pnl.BackColor = theme.Accent;
                    else if (pnl.Tag != null && pnl.Tag.ToString() == "workplace")
                        pnl.BackColor = theme.LightColor;
                    else
                        pnl.BackColor = theme.DarkColor;
                    break;
                case GroupBox grp:
                    grp.BackColor = theme.DarkColor;
                    break;
                 case CheckBox chk:
                    chk.BackColor = theme.DarkColor;
                    break;
                case IconPictureBox pic:
                    pic.BackColor = Color.Transparent;
                    pic.IconColor = theme.Text;
                    if (pic.Tag != null && pic.Tag.ToString() == "menu")
                        pic.BackColor = theme.DarkColor;
                    if (pic.Tag != null && pic.Tag.ToString() == "workplace")
                        pic.BackColor = theme.LightColor;
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
                default:
                    c.BackColor = Color.Black;
                    break;
            }
        }

        public class ThemePalette
        {
            public Color LightColor { get; set; }
            public Color DarkColor { get; set; }
            public Color HoverColor { get; set; }
            public Color Accent { get; set; }
            public Color Text { get; set; }
        }
        public static ThemePalette GetCurrentPalette()
        {
            return Themes[CurrentThemeName];
        }

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
    }
}
