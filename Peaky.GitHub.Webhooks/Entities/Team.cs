using Newtonsoft.Json;

namespace Peaky.GitHub.Webhooks.Entities
{
    public class Team
    {
        [JsonProperty("id")]
        public long Id;
        
        [JsonProperty("node_id")]
        public string NodeId;
        
        [JsonProperty("url")]
        public string Url;
        
        [JsonProperty("html_url")]
        public string HtmlUrl;
        
        [JsonProperty("name")]
        public string Name;
        
        [JsonProperty("slug")]
        public string Slug;
        
        [JsonProperty("description")]
        public string Description;
        
        [JsonProperty("privacy")]
        public string Privacy;
        
        [JsonProperty("permission")]
        public string Permission;
        
        [JsonProperty("members_url")]
        public string MembersUrl;
        
        [JsonProperty("repositories_url")]
        public string RepositoriesUrl;
        
        [JsonProperty("parent")]
        public Team Parent;
    }
}
