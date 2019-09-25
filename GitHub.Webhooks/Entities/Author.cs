using Newtonsoft.Json;

namespace GitHub.Webhooks.Entities
{
    public class  Author
    {
        /// <summary>
        /// The git author's name.
        /// </summary>
        [JsonProperty("name")]
        public string Name;
                
        /// <summary>
        /// The git author's email address.
        /// </summary>
        [JsonProperty("email")]
        public string Email;
    }
}
