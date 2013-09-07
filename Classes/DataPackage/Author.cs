using Newtonsoft.Json;

namespace MSDesigner.Classes.DataPackage
{
    class Author
    {
        [JsonProperty(Required = Required.Always)]
        public string Name { get; set; }

        [JsonProperty(Required = Required.Always)]
        public string Email { get; set; }

        [JsonProperty(Required = Required.AllowNull)]
        public string Homepage { get; set; }
    }
}
