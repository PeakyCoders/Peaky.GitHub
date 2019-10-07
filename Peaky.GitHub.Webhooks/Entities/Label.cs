using Newtonsoft.Json;

namespace Peaky.GitHub.Webhooks.Entities
{
    public class Label
    {
        [JsonProperty("id")]
        public long Id;
        
        [JsonProperty("node_id")]
        public string NodeId;
        
        [JsonProperty("url")]
        public string Url;
        
        [JsonProperty("name")]
        public string Name;
        
        [JsonProperty("color")]
        public string Color;

        [JsonProperty("default")]
        public bool Default;
    }
}
