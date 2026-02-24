using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartStock.Classes.Settings
{
    using System;
using System.IO;
using System.Text.Json;

public static class SettingsManager
{
    private static readonly string FilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "appSettings.json");
    
    // Proprietate statică pentru a accesa setările de oriunde în cod
    public static AppSettings Current { get; private set; } = new AppSettings();

    // Încarcă setările din fișier
    public static void Load()
    {
        try
        {
            if (File.Exists(FilePath))
            {
                string json = File.ReadAllText(FilePath);
                Current = JsonSerializer.Deserialize<AppSettings>(json) ?? new AppSettings();
            }
            else
            {
                // Dacă fișierul nu există, îl creăm cu valorile default
                Save();
                    Console.WriteLine("Succes: Settings file created!");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading the settings: {ex.Message}");
            Current = new AppSettings(); // Fallback la default
        }
    }

    // Salvează setările curente în fișier
    public static void Save()
    {
        try
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(Current, options);
            File.WriteAllText(FilePath, json);
            Console.WriteLine("Succes: Settings were saved!");
            Console.WriteLine("Path: " + FilePath);
            Console.WriteLine("Current Theme: " + Current.Theme.ToString());
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving the settings: {ex.Message}");
        }
    }
}
}
