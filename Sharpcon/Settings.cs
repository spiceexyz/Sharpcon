using System.IO;
using System.Windows.Forms;

using Newtonsoft.Json;

namespace Sharpcon
{
    public class Settings
    {
        public static readonly string FilePath = Path.Combine(Directory.GetCurrentDirectory(), "config.json");

        [JsonProperty("ServerAddress")]
        public string ServerAddress { get; set; }

        [JsonProperty("ServerPort")]
        public string ServerPort { get; set; }

        [JsonProperty("ServerPassword")]
        public string ServerPassword { get; set; }

        /// <summary>
        /// Settings constructor
        /// </summary>
        /// <param name="serverAddress"></param>
        /// <param name="serverPort"></param>
        /// <param name="serverPassword"></param>
        public Settings(string serverAddress, string serverPort, string serverPassword)
        {
            ServerAddress = serverAddress;
            ServerPort = serverPort;
            ServerPassword = serverPassword;
        }

        /// <summary>
        /// Writes settings to the config file
        /// </summary>
        /// <param name="settings"></param>
        public static void Write(Settings settings)
        {
            if (!File.Exists(FilePath))
                File.Create(FilePath).Close();

            File.WriteAllText(FilePath, JsonConvert.SerializeObject(settings, Formatting.Indented));
        }

        /// <summary>
        /// Reads settings from the config file
        /// </summary>
        /// <returns></returns>
        public static Settings Read()
        {
            if (!File.Exists(FilePath))
            {
                MessageBox.Show("Couldn't find a configuration file. A new one will be created.", "Sharpcon", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Write(new Settings("localhost", "28016", "password"));
            }

            var settings = JsonConvert.DeserializeObject<Settings>(File.ReadAllText(FilePath));
            return settings;
        }
    }
}
