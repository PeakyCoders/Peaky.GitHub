using System;
using Newtonsoft.Json;
using Peaky.GitHub.Webhooks.Converters;

namespace Peaky.GitHub.Webhooks.Entities
{
    public class PullRequestReview
    {
        [JsonProperty("id")]
        public long Id;

        [JsonProperty("node_id")]
        public string NodeId;
        
        [JsonProperty("user")]
        public User User;

        [JsonProperty("body")]
        public string Body;

        [JsonProperty("commit_id")]
        public string CommitId;

        [JsonProperty("submitted_at")]
        [JsonConverter(typeof(GitHubDateTimeConverter))]
        public DateTime? SubmittedAt;

        [JsonProperty("state")]
        public string State;
        
        [JsonProperty("html_url")]
        public string HtmlUrl;

        [JsonProperty("pull_request_url")]
        public string PullRequestUrl;

        [JsonProperty("author_association")]
        public string AuthorAssociation;
    }
}
