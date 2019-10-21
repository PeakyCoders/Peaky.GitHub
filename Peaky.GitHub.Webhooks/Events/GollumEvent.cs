using System.Collections.Generic;
using Newtonsoft.Json;
using Peaky.GitHub.Webhooks.Abstractions;
using Peaky.GitHub.Webhooks.Entities;

namespace Peaky.GitHub.Webhooks.Events
{
    /// <summary>
    /// Triggered when a Wiki page is created or updated.
    /// </summary>
    public class GollumEvent : GitHubEvent
    {
        public const string EventName = "gollum";

        public override string GetEventName() => EventName;

        /// <summary>
        /// The pages that were updated.
        /// </summary>
        [JsonProperty("pages")]
        public List<WikiPage> Pages;
    }
}
