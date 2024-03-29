﻿using System;
using System.Collections.Generic;
using Peaky.GitHub.Webhooks.Events;

namespace Peaky.GitHub.Webhooks.Static
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
            { StatusEvent.EventName, typeof(StatusEvent) },
            { PullRequestReviewEvent.EventName, typeof(PullRequestReviewEvent) },
            { PullRequestReviewCommentEvent.EventName, typeof(PullRequestReviewCommentEvent) },
            { StarEvent.EventName, typeof(StarEvent) },
            { WatchEvent.EventName, typeof(WatchEvent) },
            { ForkEvent.EventName, typeof(ForkEvent) },
            { GollumEvent.EventName, typeof(GollumEvent) },
            { LabelEvent.EventName, typeof(LabelEvent) },
            { MilestoneEvent.EventName, typeof(MilestoneEvent) },
            { CommitCommentEvent.EventName, typeof(CommitCommentEvent) },
            { MemberEvent.EventName, typeof(MemberEvent) },
            { PublicEvent.EventName, typeof(PublicEvent) },
            { ReleaseEvent.EventName, typeof(ReleaseEvent) },
            { ContentReferenceEvent.EventName, typeof(ContentReferenceEvent) }
        };
    }
}
