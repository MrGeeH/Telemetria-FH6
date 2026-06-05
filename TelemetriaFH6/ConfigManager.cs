using System;
using System.IO;

namespace TelemetriaFH6
{
    public static class ConfigManager
    {
        private static string configPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "MrGeH.config");

        public static string IP { get; set; } = "127.0.0.1";
        public static int Port { get; set; } = 8000;
        public static string Language { get; set; } = "PTBR";
        public static float TargetPercentage { get; set; } = 0.80f;

        public static void Load()
        {
            if (File.Exists(configPath))
            {
                try
                {
                    string[] lines = File.ReadAllLines(configPath);
                    if (lines.Length >= 4)
                    {
                        IP = lines[0].Trim();
                        Port = int.Parse(lines[1].Trim());
                        Language = lines[2].Trim();
                        TargetPercentage = float.Parse(lines[3].Trim());
                    }
                }
                catch { }
            }
            else
            {
                Save();
            }
        }

        public static void Save()
        {
            try
            {
                string[] lines = { IP, Port.ToString(), Language, TargetPercentage.ToString() };
                File.WriteAllLines(configPath, lines);
            }
            catch { }
        }
    }
}