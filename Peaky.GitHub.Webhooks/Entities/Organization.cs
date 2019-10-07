using Newtonsoft.Json;

namespace Peaky.GitHub.Webhooks.Entities
{
    public class Organization
    {
        [JsonProperty("login")]
        public string Login;
        
        [JsonProperty("id")]
        public long Id;

        [JsonProperty("node_id")]
        public string NodeId;
        
        [JsonProperty("description")]
        public string Description;
        
        [JsonProperty("url")]
        public string Url;
        
        [JsonProperty("repos_url")]
        public string ReposUrl;
        
        [JsonProperty("events_url")]
        public string EventsUrl;
        
        [JsonProperty("hooks_url")]
        public string HooksUrl;
        
        [JsonProperty("issues_url")]
        public string IssuesUrl;
        
        [JsonProperty("members_url")]
        public string MembersUrl;

        [JsonProperty("public_members_url")]
        public string PublicMembersUrl;

        [JsonProperty("avatar_url")]
        public string AvatarUrl;
    }
}
