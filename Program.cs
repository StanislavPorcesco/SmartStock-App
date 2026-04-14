using System.Runtime.InteropServices;
using Microsoft.EntityFrameworkCore;
using SmartStock.Classes.Models;
using SmartStock.Classes.Settings;
using SmartStock.Classes.Utils;


namespace SmartStock
{
    internal static class Program
    {
        [DllImport("kernel32.dll")]
        private static extern bool FreeConsole();

        [STAThread]
        static void Main()
        {
            FreeConsole();
            Console.SetOut(TextWriter.Null);
            Console.SetError(TextWriter.Null);

            ApplicationConfiguration.Initialize();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string resourcesPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources");

            if (!Directory.Exists(resourcesPath))
            {
                Directory.CreateDirectory(resourcesPath);
            }

            // Must run first — every other component reads paths from here.
            PathsManager.Load();

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
            ReportScheduler.Start();
            ExternalFactorsScheduler.Start();

            LoginForm loginForm = new LoginForm();
            ThemeManager.Apply(loginForm);
            Application.ApplicationExit += (_, __) =>
            {
                ReportScheduler.Stop();
                ExternalFactorsScheduler.Stop();
            };
            Application.Run(loginForm);
            
        }
    }
}