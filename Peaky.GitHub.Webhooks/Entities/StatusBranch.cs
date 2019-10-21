using Newtonsoft.Json;

namespace Peaky.GitHub.Webhooks.Entities
{
    public class StatusBranch
    {
        [JsonProperty("name")]
        public string Name;

        [JsonProperty("commit")]
        public StatusBranchCommit Commit;

        [JsonProperty("protected")]
        public bool Protected;
    }
}
