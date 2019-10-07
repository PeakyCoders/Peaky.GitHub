using System.Security.Cryptography;
using System.Text;

namespace Peaky.GitHub.Webhooks.Static
{
    public class GitHubWebhookSettings
    {
        /// <summary>
        /// Default settings to be used when the settings are not specified.
        /// </summary>
        public static GitHubWebhookSettings Default = new GitHubWebhookSettings(null, false);

        #region Public Fields

        /// <summary>
        /// Secret configured in the GitHub webhook settings. Will be used
        /// as key while performing the HMAC SHA1 digest.
        /// </summary>
        public readonly string Secret;

        /// <summary>
        /// Whether the deserialization of the stream body should close the underlying
        /// stream or leave it open for further usage.
        /// </summary>
        public readonly bool LeaveBodyStreamOpen;  

        #endregion

        internal readonly bool ShouldValidate;

        internal readonly HMACSHA1 SHA;

        public GitHubWebhookSettings(string secret = null, bool leaveBodyStreamOpen = false)
        {
            Secret = secret;
            LeaveBodyStreamOpen = leaveBodyStreamOpen;

            if (string.IsNullOrWhiteSpace(secret))
            {
                ShouldValidate = false;
                SHA = null;
            }
            else
            {
                ShouldValidate = true;
                SHA = new HMACSHA1(Encoding.UTF8.GetBytes(secret));
            }
        }
    }
}
