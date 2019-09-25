using Newtonsoft.Json;

namespace GitHub.Webhooks.Entities
{
    public class GitReference
    {
        [JsonProperty("label")]
        public string Label;
        
        [JsonProperty("ref")]
        public string Ref;
        
        [JsonProperty("sha")]
        public string SHA;
        
        [JsonProperty("user")]
        public User User;
        
        [JsonProperty("repo")]
        public Repository Repo;
    }
}
