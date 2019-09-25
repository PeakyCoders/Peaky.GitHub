using Newtonsoft.Json;

namespace GitHub.Webhooks.Entities
{
    public class License
    {
        [JsonProperty("key")]
        public string Key;
        
        [JsonProperty("node_id")]
        public string NodeId;
        
        [JsonProperty("name")]
        public string Name;
        
        [JsonProperty("spdx_id")]
        public string SpdxId;

        [JsonProperty("url")]
        public string Url;
    }
}
