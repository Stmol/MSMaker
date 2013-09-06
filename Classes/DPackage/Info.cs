using Newtonsoft.Json;

namespace MSDesigner.Classes.DPackage
{
    class Info
    {
        [JsonProperty(Required = Required.AllowNull)]
        public string Source { get; set; }

        [JsonProperty(Required = Required.Always)]
        public string Language { get; set; }

        [JsonProperty(Required = Required.Always)]
        public string Patch { get; set; }
    }
}
