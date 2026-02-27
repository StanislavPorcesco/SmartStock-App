using SmartStock.Classes.Settings;
using SmartStock.Classes.Utils;
using SmartStock.Forms;


namespace SmartStock
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // 1. Încarcă setările din JSON
            SettingsManager.Load();

            // 2. Setează tema curentă în manager (asta doar pregătește paleta)
            ThemeManager.SetTheme(SettingsManager.Current.Theme);
            // 3. Creează instanța formei
            LoginForm loginForm = new LoginForm();
            //MenuForm menuForm = new MenuForm();

            //ThemeManager.Apply(menuForm);
            //Application.Run(menuForm);
            // 4. Aplică tema pe instanța creată înainte de Run
            ThemeManager.Apply(loginForm);
            Application.Run(loginForm);
            
        }
    }
}