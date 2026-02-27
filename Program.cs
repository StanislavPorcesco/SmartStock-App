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

            SettingsManager.Load();
            ThemeManager.SetTheme(SettingsManager.Current.Theme);

            LoginForm loginForm = new LoginForm();

            //Form loginForm = new Form1();


            //ThemeManager.Apply(loginForm);
            Application.Run(loginForm);
            
        }
    }
}