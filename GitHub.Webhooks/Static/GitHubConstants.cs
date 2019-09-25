using System;
using System.Collections.Generic;
using GitHub.Webhooks.Events;

namespace GitHub.Webhooks.Static
{
    internal static class GitHubConstants
    {
        public const string EventHeader = "X-GitHub-Event";

        public const string SignatureHeader = "X-Hub-Signature";

        public static readonly IReadOnlyDictionary<string, Type> EventNameToTypeMap = new Dictionary<string, Type>()
        {
            { CreateEvent.EventName, typeof(CreateEvent) },
            { DeleteEvent.EventName, typeof(DeleteEvent) },
            { IssuesEvent.EventName, typeof(IssuesEvent) },
            { IssueCommentEvent.EventName, typeof(IssueCommentEvent) },
            { PullRequestEvent.EventName, typeof(PullRequestEvent) },
            { PushEvent.EventName, typeof(PushEvent) },
        };
    }
}
