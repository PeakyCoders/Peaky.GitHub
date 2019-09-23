using System.Security.Cryptography;
using System.Text;

namespace GitHub.Webhooks.Static
{
    public class GitHubWebhookSettings
    {
        public static GitHubWebhookSettings Default = new GitHubWebhookSettings(null, false);

        #region Public Fields

        public readonly string Secret;

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
