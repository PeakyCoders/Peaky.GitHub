using Newtonsoft.Json;
using Peaky.GitHub.Webhooks.Abstractions;
using Peaky.GitHub.Webhooks.Entities;

namespace Peaky.GitHub.Webhooks.Events
{
    /// <summary>
    /// Triggered on a push to a repository branch. Branch pushes and repository tag pushes also trigger webhook push events.
    /// </summary>
    /// <remarks>
    /// Note: You will not receive a webhook for this event when you push more than three tags at once.
    /// </remarks>
    public class PushEvent : GitHubEvent
    {
        public const string EventName = "push";

        public override string GetEventName() => EventName;

        /// <summary>
        /// The full git ref that was pushed.
        /// </summary>
        [JsonProperty("ref")]
        public string Ref;

        /// <summary>
        /// The SHA of the most recent commit on ref before the push.
        /// </summary>
        [JsonProperty("before")]
        public string Before;
        
        /// <summary>
        /// The SHA of the most recent commit on ref before the push.
        /// </summary>
        [JsonProperty("after")]
        public string After;
        
        [JsonProperty("pusher")]
        public object Pusher;
        
        [JsonProperty("after")]
        public bool Created;
        
        [JsonProperty("deleted")]
        public bool Deleted;
        
        [JsonProperty("forced")]
        public bool Forced;
        
        [JsonProperty("base_ref")]
        public string BaseRef;
        
        [JsonProperty("compare")]
        public string Compare;

        /// <summary>
        /// An array of commit objects describing the pushed commits.
        /// </summary>
        [JsonProperty("commits")]
        public Commit[] Commits;
        
        [JsonProperty("head_commit")]
        public Commit HeadCommit;
    }
}
