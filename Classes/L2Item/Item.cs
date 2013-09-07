using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Drawing;
using System.IO;

namespace MSDesigner.Classes.L2Item
{
    [XmlRoot(Namespace = "MSDesigner.Classes.L2Item")]
    public class Item
    {
        [XmlAttribute("id")]
        [JsonProperty(Required = Required.Always)]
        public Int32 Id { get; set; }

        [XmlIgnore]
        [JsonProperty(Required = Required.Always)]
        public String Name { get; set; }

        [XmlIgnore]
        [JsonProperty(Required = Required.AllowNull)]
        public String Icon { get; set; }

        [XmlIgnore]
        [JsonProperty(Required = Required.AllowNull)]
        public String Description { get; set; }

        [XmlIgnore]
        [JsonProperty(Required = Required.Default)]
        public Dictionary<string, string> Params { get; set; }

        /// <summary>
        /// Return image file for current Item
        /// </summary>
        /// <param name="pathToIcons">Global path from config</param>
        /// <param name="iconFormat">Format of image file</param>
        /// <returns>Image object</returns>
        public Image GetIconImage(string pathToIcons, string iconFormat = "png")
        {
            string path = string.Format(@"{0}\{1}.{2}", pathToIcons, this.Icon, iconFormat);

            if (File.Exists(path))
                return Image.FromFile(path);

            return Properties.Resources.no_icon;
        }
    }
}
