using Newtonsoft.Json;

namespace Peaky.GitHub.Webhooks.Entities
{
    public class MemberChanges
    {
        /// <summary>
        /// The previous permissions of the collaborator if the action was edited.
        /// </summary>
        [JsonProperty("old_permission")]
        public ChangeFrom OldPermission;
    }
}
