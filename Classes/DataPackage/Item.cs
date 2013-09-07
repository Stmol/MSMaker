using Newtonsoft.Json;

namespace MSDesigner.Classes.DataPackage
{
    class Item
    {
        [JsonProperty(Required = Required.Always)]
        public string Name { get; set; }

        [JsonProperty(Required = Required.Always)]
        public string Path { get; set; }
    }
}
