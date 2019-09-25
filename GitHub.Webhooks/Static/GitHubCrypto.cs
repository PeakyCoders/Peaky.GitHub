using System.IO;
using GitHub.Webhooks.Exceptions;

namespace GitHub.Webhooks.Static
{
    internal static class GitHubCrypto
    {
        public static bool ValidateSignature(string signature, Stream body, GitHubWebhookSettings settings)
        {
            byte[] signatureBytes = HexToBinary(signature);
            byte[] computedBytes = settings.SHA.ComputeHash(body);

            return SafeEquals(signatureBytes, computedBytes);
        }

        private static byte[] HexToBinary(string text)
        {
            if (text.Length % 2 != 0)
            {
                throw new GitHubWebhookException("Expected a hex string of even length");
            }

            byte[] result = new byte[text.Length / 2];

            for (int i = 0; i < text.Length; i += 2)
            {
                int a = GetHexValue(text[i]) << 4;
                int b = GetHexValue(text[i + 1]);

                result[i / 2] = (byte) (a + b);
            }

            return result;
        }

        private static int GetHexValue(char c)
        {
            if (c >= '0' && c <= '9')
            {
                return c - '0';
            }
            else if (c >= 'A' && c <= 'F')
            {
                return c - 'A' + 10;
            }
            else if (c >= 'a' && c <= 'f')
            {
                return c - 'a' + 10;
            }
            else
            {
                throw new GitHubWebhookException($"Unexpected hex value '{c}'");
            }
        }

        private static bool SafeEquals(byte[] x, byte[] y)
        {
            if (x.Length != y.Length)
            {
                throw new GitHubWebhookException("Mismatched byte array lengths");
            }

            int diff = 0;

            for (int i = 0; i < x.Length; i++)
            {
                diff |= x[i] ^ y[i];
            }

            return diff == 0;
        }
    }
}
