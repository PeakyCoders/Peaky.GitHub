using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Peaky.GitHub.Webhooks.Converters;

namespace Peaky.GitHub.Webhooks.Entities
{
    public class Issue
    {
        [JsonProperty("id")]
        public long Id;

        [JsonProperty("node_id")]
        public string NodeId;

        [JsonProperty("number")]
        public int Number;

        [JsonProperty("title")]
        public string Title;

        [JsonProperty("state")]
        public string State;

        [JsonProperty("locked")]
        public bool Locked;

        [JsonProperty("assignee")]
        public User Assignee;
        
        [JsonProperty("assignees")]
        public List<User> Assignees;
        
        [JsonProperty("milestone")]
        public Milestone Milestone;

        [JsonProperty("comments")]
        public int Comments;
        
        [JsonProperty("created_at")]
        [JsonConverter(typeof(GitHubDateTimeConverter))]
        public DateTime? CreatedAt;
        
        [JsonProperty("updated_at")]
        [JsonConverter(typeof(GitHubDateTimeConverter))]
        public DateTime? UpdatedAt;

        [JsonProperty("closed_at")]
        [JsonConverter(typeof(GitHubDateTimeConverter))]
        public DateTime? ClosedAt;

        [JsonProperty("author_association")]
        public string AuthorAssociation;

        [JsonProperty("body")]
        public string Body;
    }
}
