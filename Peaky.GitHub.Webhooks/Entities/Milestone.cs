using System;
using Newtonsoft.Json;
using Peaky.GitHub.Webhooks.Converters;

namespace Peaky.GitHub.Webhooks.Entities
{
    public class Milestone
    {
        [JsonProperty("id")]
        public long Id;

        [JsonProperty("node_id")]
        public string NodeId;

        [JsonProperty("number")]
        public int Number;
        
        [JsonProperty("title")]
        public string Title;
        
        [JsonProperty("description")]
        public string Description;

        [JsonProperty("creator")]
        public User Creator;
        
        [JsonProperty("open_issues")]
        public int OpenIssues;
        
        [JsonProperty("closed_issues")]
        public int ClosedIssues;

        [JsonProperty("state")]
        public string State;
        
        [JsonProperty("created_at")]
        [JsonConverter(typeof(GitHubDateTimeConverter))]
        public DateTime? CreatedAt;
        
        [JsonProperty("updated_at")]
        [JsonConverter(typeof(GitHubDateTimeConverter))]
        public DateTime? UpdatedAt;
        
        [JsonProperty("due_on")]
        [JsonConverter(typeof(GitHubDateTimeConverter))]
        public DateTime? DueOn;
        
        [JsonProperty("closed_at")]
        [JsonConverter(typeof(GitHubDateTimeConverter))]
        public DateTime? ClosedAt;

        [JsonProperty("url")]
        public string Url;
        
        [JsonProperty("html_url")]
        public string HtmlUrl;

        [JsonProperty("labels_url")]
        public string LabelsUrl;
    }
}
