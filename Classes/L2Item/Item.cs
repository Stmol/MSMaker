using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Xml.Serialization;

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
    }
}
