using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Peaky.GitHub.Webhooks.Converters;

namespace Peaky.GitHub.Webhooks.Entities
{
    public class Commit
    {
        [JsonProperty("id")]
        public string Id;
        
        [JsonProperty("tree_id")]
        public string TreeId;
        
        [JsonProperty("message")]
        public string Message;
        
        [JsonProperty("timestamp")]
        [JsonConverter(typeof(GitHubDateTimeConverter))]
        public DateTime? Timestamp;

        [JsonProperty("author")]
        public Author Author;
        
        [JsonProperty("committer")]
        public Author Committer;

        [JsonProperty("url")]
        public string Url;

        [JsonProperty("distinct")]
        public bool Distinct;
        
        [JsonProperty("added")]
        public List<string> Added;
        
        [JsonProperty("removed")]
        public List<string> Removed;
        
        [JsonProperty("modified")]
        public List<string> Modified;
    }
}
