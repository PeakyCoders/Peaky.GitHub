using System;
using Newtonsoft.Json;

namespace Peaky.GitHub.Webhooks.Entities
{
    public class Comment
    {
        [JsonProperty("id")]
        public long Id;

        [JsonProperty("node_id")]
        public string NodeId;

        [JsonProperty("user")]
        public User User;

        [JsonProperty("url")]
        public string Url;
        
        [JsonProperty("html_url")]
        public string HtmlUrl;
        
        [JsonProperty("issue_url")]
        public string IssueUrl;

        [JsonProperty("created_at")]
        public DateTime CreatedAt;
        
        [JsonProperty("updated_at")]
        public DateTime UpdatedAt;

        [JsonProperty("author_association")]
        public string AuthorAssociation;

        [JsonProperty("body")]
        public string Body;
    }
}
