using Newtonsoft.Json;

namespace GitHub.Webhooks.Entities
{
    public class User
    {
        [JsonProperty("login")]
        public string Login;
        
        [JsonProperty("id")]
        public long Id;

        [JsonProperty("node_id")]
        public string NodeId;
        
        [JsonProperty("avatar_url")]
        public string AvatarUrl;

        [JsonProperty("gravatar_id")]
        public string GravatarId;
        
        [JsonProperty("url")]
        public string Url;
        
        [JsonProperty("html_url")]
        public string HtmlUrl;
        
        [JsonProperty("followers_url")]
        public string FollowersUrl;
        
        [JsonProperty("following_url")]
        public string FollowingUrl;
        
        [JsonProperty("gists_url")]
        public string GistsUrl;
        
        [JsonProperty("starred_url")]
        public string StarredUrl;
        
        [JsonProperty("subscriptions_url")]
        public string SubscriptionsUrl;
        
        [JsonProperty("organizations_url")]
        public string OrganizationsUrl;
        
        [JsonProperty("repos_url")]
        public string ReposUrl;
        
        [JsonProperty("events_url")]
        public string EventsUrl;
        
        [JsonProperty("received_events_url")]
        public string ReceivedEventsUrl;
        
        [JsonProperty("type")]
        public string Type;

        [JsonProperty("site_admin")]
        public bool SiteAdmin;
    }
}
