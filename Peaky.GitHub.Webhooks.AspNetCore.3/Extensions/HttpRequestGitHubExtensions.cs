using System;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Primitives;
using Newtonsoft.Json;
using Peaky.GitHub.Webhooks.Abstractions;
using Peaky.GitHub.Webhooks.Exceptions;
using Peaky.GitHub.Webhooks.Static;

namespace Peaky.GitHub.Webhooks.AspNetCore.Extensions
{
    public static class HttpRequestGitHubExtensions
    {
        private static readonly JsonSerializer JsonSerializer = new JsonSerializer();

        public static GitHubEvent GetGitHubEvent(this HttpRequest request, GitHubWebhookSettings settings = null)
        {
            settings = settings ?? GitHubWebhookSettings.Default;

            // If signature validation is enabled, we'll need to read the body stream twice,
            // first to compute the SHA1 and then to deserialize into an GitHubEvent
            if (settings.ShouldValidate && !request.Body.CanSeek)
            {
                request.EnableBuffering();
            }

            // Only validate event signature if a secret has been defined
            if (!string.IsNullOrWhiteSpace(settings.Secret))
            {
                string signature = GetGitHubEventSignature(request);

                request.Body.Seek(0, SeekOrigin.Begin);
                bool isValid = GitHubCrypto.ValidateSignature(signature, request.Body, settings);
                    
                if (!isValid)
                {
                    throw new GitHubWebhookException("Invalid event signature");
                }
            }

            request.Body.Seek(0, SeekOrigin.Begin);
            using (StreamReader reader = new StreamReader(request.Body, Encoding.UTF8, false, 1024, settings.LeaveBodyStreamOpen))
            {
                Type eventType = GetGitHubEventType(request);

                return (GitHubEvent) JsonSerializer.Deserialize(reader, eventType);
            }
        }

        private static string GetGitHubEventName(HttpRequest request)
        {
            StringValues header = request.Headers[GitHubConstants.EventHeader];

            if (header == StringValues.Empty)
            {
                throw new GitHubWebhookException($"Missing {GitHubConstants.EventHeader} header");
            }
            
            string eventName = header.First();

            if (string.IsNullOrWhiteSpace(eventName))
            {
                throw new GitHubWebhookException($"Null, empty or whitespace event name in {GitHubConstants.EventHeader} header");
            }

            return eventName;
        }

        private static Type GetGitHubEventType(HttpRequest request)
        {
            string eventName = GetGitHubEventName(request);
                
            bool success = GitHubConstants.EventNameToTypeMap.TryGetValue(eventName, out Type eventType);

            if (!success)
            {
                throw new GitHubWebhookException($"'{eventName}' is not a valid event name");
            }

            return eventType;
        }

        private static string GetGitHubEventSignature(HttpRequest request)
        {
            StringValues header = request.Headers[GitHubConstants.SignatureHeader];

            if (header == StringValues.Empty)
            {
                throw new GitHubWebhookException($"Missing {GitHubConstants.SignatureHeader} header");
            }
            
            string signature = header.First();

            if (string.IsNullOrWhiteSpace(signature))
            {
                throw new GitHubWebhookException($"Null, empty or whitespace signature in {GitHubConstants.SignatureHeader} header");
            }

            if (!signature.StartsWith("sha1="))
            {
                throw new GitHubWebhookException("Unexpected signature type (expected SHA1)");
            }

            return signature.Substring("sha1=".Length);
        }
    }
}
