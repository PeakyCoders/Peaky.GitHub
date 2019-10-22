using Newtonsoft.Json;

namespace Peaky.GitHub.Webhooks.Entities
{
    public class ReleaseChanges
    {
        /// <summary>
        /// The previous version of the name if the action was edited.
        /// </summary>
        [JsonProperty("name")]
        public ChangeFrom Name;
        
        /// <summary>
        /// The previous version of the body if the action was edited.
        /// </summary>
        [JsonProperty("body")]
        public ChangeFrom Body;
    }
}
