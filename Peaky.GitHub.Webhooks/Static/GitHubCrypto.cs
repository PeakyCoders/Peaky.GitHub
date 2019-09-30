using System.IO;
using Peaky.GitHub.Webhooks.Exceptions;

namespace Peaky.GitHub.Webhooks.Static
{
    internal static class GitHubCrypto
    {
        /// <summary>
        /// Validates a GitHub event signature (SHA1) and the body payload.
        /// </summary>
        /// <param name="signature">GitHub event signature (X-Hub-Signature).</param>
        /// <param name="body">GitHub webhook event body stream.</param>
        /// <param name="settings">GitHub webhook settings.</param>
        /// <returns>Whether the signature is valid or not.</returns>
        public static bool ValidateSignature(string signature, Stream body, GitHubWebhookSettings settings)
        {
            byte[] signatureBytes = HexToBinary(signature);
            byte[] computedBytes = settings.SHA.ComputeHash(body);

            return SafeEquals(signatureBytes, computedBytes);
        }

        /// <summary>
        /// Get the binary representation of a hexadecimal string.
        /// </summary>
        /// <param name="text">Hexadecimal string.</param>
        /// <returns>Binary representation.</returns>
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

        /// <summary>
        /// Get the decimal value of a character in hexadecimal.
        /// </summary>
        /// <param name="c">Hexadecimal character.</param>
        /// <returns>Decimal value.</returns>
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

        /// <summary>
        /// Compares two byte arrays in constant time, safe against timing attacks.
        /// </summary>
        /// <param name="x">First byte array.</param>
        /// <param name="y">Second byte array.</param>
        /// <returns>Whether both byte arrays are equal or not.</returns>
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
