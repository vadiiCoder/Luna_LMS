using System.Text.Json;
using System.IO;

namespace Luna_LMS.Helpers
{
    public static class RememberMeHelper
    {
        private static string filePath =
            "remember.json";

        public static void Save(
            string username)
        {
            File.WriteAllText(
                filePath,
                JsonSerializer.Serialize(username));
        }

        public static string Load()
        {
            if (!File.Exists(filePath))
                return "";

            return JsonSerializer.Deserialize<string>(
                File.ReadAllText(filePath));
        }
    }
}