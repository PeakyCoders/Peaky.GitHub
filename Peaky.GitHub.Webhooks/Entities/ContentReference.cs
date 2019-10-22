using Newtonsoft.Json;

namespace Peaky.GitHub.Webhooks.Entities
{
    public class ContentReference
    {
        [JsonProperty("id")]
        public long Id;
        
        [JsonProperty("node_id")]
        public string NodeId;

        [JsonProperty("reference")]
        public string Reference;
    }
}
