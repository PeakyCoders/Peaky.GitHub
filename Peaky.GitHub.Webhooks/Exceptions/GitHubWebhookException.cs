using System;

namespace Peaky.GitHub.Webhooks.Exceptions
{
    public class GitHubWebhookException : Exception
    {
        public GitHubWebhookException(string message) : base(message)
        {
        }

        public GitHubWebhookException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
