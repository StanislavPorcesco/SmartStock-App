using Microsoft.EntityFrameworkCore;
using SmartStock.Classes.Models;
using SmartStock.Classes.Settings;
using SmartStock.Classes.Utils;


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

            string resourcesPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources");

            if (!Directory.Exists(resourcesPath))
            {
                Directory.CreateDirectory(resourcesPath);
            }

            try
            {
                using (var db = new SmartStockContext())
                {
                    db.Database.Migrate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error initializing the database: {ex.Message}",
                                "Critical Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
                throw;
            }

            SettingsManager.Load();
            ThemeManager.SetTheme(SettingsManager.Current.Theme);
            LoginForm loginForm = new LoginForm();
            ThemeManager.Apply(loginForm);
            Application.Run(loginForm);
            
        }
    }
}