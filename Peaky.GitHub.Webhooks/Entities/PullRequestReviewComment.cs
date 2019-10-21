using System;
using Newtonsoft.Json;
using Peaky.GitHub.Webhooks.Converters;

namespace Peaky.GitHub.Webhooks.Entities
{
    public class PullRequestReviewComment
    {
        [JsonProperty("pull_request_review_id")]
        public long PullRequestReviewId;

        [JsonProperty("id")]
        public long Id;

        [JsonProperty("node_id")]
        public string NodeId;

        [JsonProperty("url")]
        public string Url;

        [JsonProperty("diff_hunk")]
        public string DiffHunk;
        
        [JsonProperty("path")]
        public string Path;
        
        [JsonProperty("position")]
        public long Position;
        
        [JsonProperty("original_position")]
        public long OriginalPosition;
        
        [JsonProperty("commit_id")]
        public string CommitId;
        
        [JsonProperty("original_commit_id")]
        public string OriginalCommitId;

        [JsonProperty("user")]
        public User User;

        [JsonProperty("body")]
        public string Body;

        [JsonProperty("created_at")]
        [JsonConverter(typeof(GitHubDateTimeConverter))]
        public DateTime? CreatedAt;
        
        [JsonProperty("updated_at")]
        [JsonConverter(typeof(GitHubDateTimeConverter))]
        public DateTime? UpdatedAt;
        
        [JsonProperty("html_url")]
        public string HtmlUrl;
        
        [JsonProperty("pull_request_url")]
        public string PullRequestUrl;

        [JsonProperty("author_association")]
        public string AuthorAssociation;
    }
}
