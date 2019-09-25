using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using GitHub.Webhooks.Abstractions;
using GitHub.Webhooks.Exceptions;
using GitHub.Webhooks.Static;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;
using Microsoft.Extensions.Primitives;
using Newtonsoft.Json;

namespace GitHub.Webhooks.Extensions
{
    public static class HttpRequestGitHubExtensions
    {
        public static string GetGitHubEventName(this HttpRequest request)
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

        public static Type GetGitHubEventType(this HttpRequest request)
        {
            string eventName = request.GetGitHubEventName();
                
            bool success = GitHubConstants.EventNameToTypeMap.TryGetValue(eventName, out Type eventType);

            if (!success)
            {
                throw new GitHubWebhookException($"'{eventName}' is not a valid event name");
            }

            return eventType;
        }

        public static string GetGitHubEventSignature(this HttpRequest request)
        {
            StringValues header = request.Headers[GitHubConstants.SignatureHeader];

            if (header == StringValues.Empty)
            {
                throw new GitHubWebhookException($"Missing {GitHubConstants.SignatureHeader} header");
            }
            
            string eventName = header.First();

            if (string.IsNullOrWhiteSpace(eventName))
            {
                throw new GitHubWebhookException($"Null, empty or whitespace signature in {GitHubConstants.EventHeader} header");
            }

            if (!eventName.StartsWith("sha1="))
            {
                throw new GitHubWebhookException("Unexpected signature type (expected SHA1)");
            }

            return eventName.Substring("sha1=".Length);
        }
        
        public static GitHubEvent GetGitHubEvent(this HttpRequest request, GitHubWebhookSettings settings = null)
        {
            settings = settings ?? GitHubWebhookSettings.Default;

            // If signature validation is enabled, we'll need to read the body stream twice,
            // first to compute the SHA1 and then to deserialize into an GitHubEvent
            if (settings.ShouldValidate && !request.Body.CanSeek)
            {
                request.EnableRewind();
            }

            // Only validate event signature if a secret has been defined
            if (!string.IsNullOrWhiteSpace(settings.Secret))
            {
                request.Body.Seek(0, SeekOrigin.Begin);
                bool isValid = GitHubCrypto.ValidateSignature(request.GetGitHubEventSignature(), request.Body, settings);
                    
                if (!isValid)
                {
                    throw new GitHubWebhookException("Invalid event signature");
                }
            }

            request.Body.Seek(0, SeekOrigin.Begin);
            using (StreamReader reader = new StreamReader(request.Body, Encoding.UTF8, false, 1024, settings.LeaveBodyStreamOpen))
            {
                Type eventType = request.GetGitHubEventType();

                return (GitHubEvent) new JsonSerializer().Deserialize(reader, eventType);
            }
        }
    }
}
