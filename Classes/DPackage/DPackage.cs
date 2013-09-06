using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace MSDesigner.Classes.DPackage
{
    class Config
    {
        [JsonProperty(Required = Required.Always)]
        public string Name { get; set; }

        [JsonProperty(Required = Required.AllowNull)]
        public string Version { get; set; }

        [JsonProperty(Required = Required.Always)]
        public string License { get; set; }

        [JsonProperty(Required = Required.Always)]
        public IList<Author> Authors { get; set; }

        [JsonProperty(Required = Required.Always)]
        public Info Info { get; set; }

        [JsonProperty(Required = Required.Always)]
        public IList<Item> Items { get; set; }

        [JsonProperty(Required = Required.Default)]
        public string Icons { get; set; }

        public static Config ReadConfigFile(string configFileName)
        {
            if (!File.Exists(string.Format(@"{0}\{1}", Application.StartupPath, configFileName)))
            {
                MessageBox.Show("Config file doesnt exists", "Error IO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            try
            {
                return JsonConvert.DeserializeObject<Config>(File.ReadAllText(configFileName));
            }
            catch (JsonSerializationException e)
            {
                MessageBox.Show(e.Message.ToString(), "Incorrect config file format", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                Application.Exit();
            }

            return null;
        }

        public string GetPathToIcon(string iconName, string iconFormat = "png")
        {
            return string.Format(@"{0}\{1}.{2}", this.Icons, iconName, iconFormat);
        }
    }
}
