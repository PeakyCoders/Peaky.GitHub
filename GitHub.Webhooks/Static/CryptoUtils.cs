using GitHub.Webhooks.Exceptions;

namespace GitHub.Webhooks.Static
{
    internal class CryptoUtils
    {
        public static bool ConstantTimeEqual(byte[] x, byte[] y)
        {
            if (x.Length != y.Length)
            {
                throw new GitHubWebhookException("Missmatched byte array lengths");
            }

            int diff = 0;

            for (int i = 0; i < x.Length; ++i)
            {
                diff |= x[i] ^ y[i];
            }

            return diff == 0;
        }
    }
}
