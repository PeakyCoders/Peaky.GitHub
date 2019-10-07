using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Peaky.GitHub.Webhooks.Converters;

namespace Peaky.GitHub.Webhooks.Entities
{
    public class PullRequest
    {
        [JsonProperty("id")]
        public long Id;

        [JsonProperty("node_id")]
        public string NodeId;
        
        [JsonProperty("url")]
        public string Url;
        
        [JsonProperty("html_url")]
        public string HtmlUrl;
        
        [JsonProperty("diff_url")]
        public string DiffUrl;
        
        [JsonProperty("patch_url")]
        public string PatchUrl;
        
        [JsonProperty("issue_url")]
        public string IssueUrl;
        
        [JsonProperty("number")]
        public int Number;
        
        [JsonProperty("state")]
        public string State;
        
        [JsonProperty("locked")]
        public bool Locked;
        
        [JsonProperty("title")]
        public string Title;
        
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
        
        [JsonProperty("closed_at")]
        [JsonConverter(typeof(GitHubDateTimeConverter))]
        public DateTime? ClosedAt;
        
        [JsonProperty("merged_at")]
        [JsonConverter(typeof(GitHubDateTimeConverter))]
        public DateTime? MergedAt;
        
        [JsonProperty("merge_commit_sha")]
        public string MergeCommitSHA;
        
        [JsonProperty("assignee")]
        public User Assignee;
        
        [JsonProperty("assignees")]
        public List<User> Assignees;
        
        [JsonProperty("requested_reviewers")]
        public List<User> RequestedReviewers;
        
        [JsonProperty("requested_teams")]
        public List<Team> RequestedTeams;

        [JsonProperty("labels")]
        public List<Label> Labels;
        
        [JsonProperty("milestone")]
        public Milestone Milestone;
        
        [JsonProperty("commits_url")]
        public string CommitsUrl;
        
        [JsonProperty("review_comments_url")]
        public string ReviewCommentsUrl;
        
        [JsonProperty("review_comment_url")]
        public string ReviewCommentUrl;
        
        [JsonProperty("comments_url")]
        public string CommentsUrl;

        [JsonProperty("statuses_url")]
        public string StatusesUrl;
        
        [JsonProperty("head")]
        public GitReference Head;
        
        [JsonProperty("base")]
        public GitReference Base;
        
        [JsonProperty("author_association")]
        public string AuthorAssociation;
        
        [JsonProperty("draft")]
        public bool Draft;
        
        [JsonProperty("merged")]
        public bool Merged;
        
        [JsonProperty("mergeable")]
        public bool? Mergeable;
        
        [JsonProperty("rebaseable")]
        public bool? Rebaseable;
        
        [JsonProperty("mergeable_state")]
        public string MergeableState;
        
        [JsonProperty("merged_by")]
        public User MergedBy;
        
        [JsonProperty("comments")]
        public int Comments;
        
        [JsonProperty("review_comments")]
        public int ReviewComments;
        
        [JsonProperty("maintainer_can_modify")]
        public bool MaintainerCanModify;
        
        [JsonProperty("commits")]
        public int Commits;
        
        [JsonProperty("additions")]
        public int Additions;
        
        [JsonProperty("deletions")]
        public int Deletions;
        
        [JsonProperty("changed_files")]
        public int ChangedFiles;
    }
}
