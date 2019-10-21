using Newtonsoft.Json;

namespace Peaky.GitHub.Webhooks.Entities
{
    public class MilestoneChanges
    {
        /// <summary>
        /// The previous version of the title if the action was edited.
        /// </summary>
        [JsonProperty("title")]
        public ChangeFrom Title;

        /// <summary>
        /// The previous version of the due date if the action was edited.
        /// </summary>
        [JsonProperty("due_on")]
        public ChangeFrom DueOn;
        
        /// <summary>
        /// The previous version of the description if the action was edited.
        /// </summary>
        [JsonProperty("description")]
        public ChangeFrom Description;
    }
}
