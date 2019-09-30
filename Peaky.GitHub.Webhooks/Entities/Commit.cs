using Newtonsoft.Json;

namespace Peaky.GitHub.Webhooks.Entities
{
    public class Commit
    {
        /// <summary>
        /// The SHA of the commit.
        /// </summary>
        [JsonProperty("sha")]
        public string SHA;
            
        /// <summary>
        /// The commit message.
        /// </summary>
        [JsonProperty("message")]
        public string Message;

        /// <summary>
        /// The git author of the commit.
        /// </summary>
        [JsonProperty("author")]
        public Author Author;

        /// <summary>
        /// URL that points to the commit API resource.
        /// </summary>
        [JsonProperty("url")]
        public string Url;

        /// <summary>
        /// Whether this commit is distinct from any that have been pushed before.
        /// </summary>
        [JsonProperty("distinct")]
        public bool Distinct;
    }
}
