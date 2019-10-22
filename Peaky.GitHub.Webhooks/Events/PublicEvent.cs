using Peaky.GitHub.Webhooks.Abstractions;

namespace Peaky.GitHub.Webhooks.Events
{
    /// <summary>
    /// Triggered when a private repository is made public. Without a doubt: the best GitHub event.
    /// </summary>
    public class PublicEvent : GitHubEvent
    {
        public const string EventName = "public";

        public override string GetEventName() => EventName;
    }
}
