using System;
using Newtonsoft.Json;
using Peaky.GitHub.Webhooks.Converters;

namespace Peaky.GitHub.Webhooks.Entities
{
    public class ReleaseAsset
    {
        [JsonProperty("id")]
        public long Id;

        [JsonProperty("node_id")]
        public string NodeId;
        
        [JsonProperty("url")]
        public string Url;
        
        [JsonProperty("browser_download_url")]
        public string BrowserDownloadUrl;

        [JsonProperty("name")]
        public string Name;

        [JsonProperty("label")]
        public string Label;
        
        [JsonProperty("state")]
        public string State;

        [JsonProperty("content_type")]
        public string ContentType;

        [JsonProperty("size")]
        public long Size;

        [JsonProperty("download_count")]
        public long DownloadCount;
        
        [JsonProperty("created_at")]
        [JsonConverter(typeof(GitHubDateTimeConverter))]
        public DateTime? CreatedAt;
        
        [JsonProperty("updated_at")]
        [JsonConverter(typeof(GitHubDateTimeConverter))]
        public DateTime? UpdatedAt;

        [JsonProperty("uploader")]
        public User Uploader;
    }
}
