using Newtonsoft.Json;

namespace Peaky.GitHub.Webhooks.Entities
{
    public class Changes
    {
        /// <summary>
        /// The previous version of the title if the action was 'edited'.
        /// </summary>
        [JsonProperty("title")]
        public ChangeFrom Title;
        
        /// <summary>
        /// The previous version of the body if the action was 'edited'.
        /// </summary>
        [JsonProperty("body")]
        public ChangeFrom Body;
    }
}
