using GitHub.Webhooks.Abstractions;
using Newtonsoft.Json;

namespace GitHub.Webhooks.Events
{
    /// <summary>
    /// Triggered on a push to a repository branch. Branch pushes and repository tag pushes also trigger webhook push events.
    /// </summary>
    /// <remarks>
    /// Note: You will not receive a webhook for this event when you push more than three tags at once.
    /// </remarks>
    public class PushEvent : GitHubEvent
    {
        [JsonIgnore]
        public override string EventType => "push";

        /// <summary>
        /// The full git ref that was pushed.
        /// </summary>
        [JsonProperty("ref")]
        public string Ref;

        /// <summary>
        /// The SHA of the most recent commit on ref after the push.
        /// </summary>
        [JsonProperty("head")]
        public string Head;

        /// <summary>
        /// The SHA of the most recent commit on ref before the push.
        /// </summary>
        [JsonProperty("before")]
        public string Before;
        
        /// <summary>
        /// The number of commits in the push.
        /// </summary>
        [JsonProperty("size")]
        public int Size;
        
        /// <summary>
        /// The number of distinct commits in the push.
        /// </summary>
        [JsonProperty("distinct_size")]
        public int DistinctSize;

        /// <summary>
        /// An array of commit objects describing the pushed commits.
        /// </summary>
        [JsonProperty("commits")]
        public Commit[] Commits;

        public class Commit
        {
            /// <summary>
            /// The SHA of the commit.
            /// </summary>
            [JsonProperty("sha")]
            public string SHA;
            
            /// <summary>
            /// The commit message.
            /// </summary>
            [JsonProperty("message")]
            public string Message;

            /// <summary>
            /// The git author of the commit.
            /// </summary>
            [JsonProperty("author")]
            public CommitAuthor Author;

            /// <summary>
            /// URL that points to the commit API resource.
            /// </summary>
            [JsonProperty("url")]
            public string Url;

            /// <summary>
            /// Whether this commit is distinct from any that have been pushed before.
            /// </summary>
            [JsonProperty("distinct")]
            public bool Distinct;

            public class CommitAuthor
            {
                /// <summary>
                /// The git author's name.
                /// </summary>
                [JsonProperty("name")]
                public string Name;
                
                /// <summary>
                /// The git author's email address.
                /// </summary>
                [JsonProperty("email")]
                public string Email;
            }
        }
    }
}
