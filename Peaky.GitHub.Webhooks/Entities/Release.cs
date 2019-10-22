using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Peaky.GitHub.Webhooks.Converters;

namespace Peaky.GitHub.Webhooks.Entities
{
    public class Release
    {
        [JsonProperty("id")]
        public long Id;

        [JsonProperty("node_id")]
        public string NodeId;
        
        [JsonProperty("url")]
        public string Url;
        
        [JsonProperty("html_url")]
        public string HtmlUrl;

        [JsonProperty("assets_url")]
        public string AssetsUrl;
        
        [JsonProperty("upload_url")]
        public string UploadUrl;
        
        [JsonProperty("tag_name")]
        public string TagName;
        
        [JsonProperty("target_commitish")]
        public string TargetCommitish;

        [JsonProperty("name")]
        public string Name;

        [JsonProperty("draft")]
        public bool Draft;

        [JsonProperty("author")]
        public User Author;

        [JsonProperty("prerelease")]
        public bool Prerelease;
        
        [JsonProperty("created_at")]
        [JsonConverter(typeof(GitHubDateTimeConverter))]
        public DateTime? CreatedAt;
        
        [JsonProperty("published_at")]
        [JsonConverter(typeof(GitHubDateTimeConverter))]
        public DateTime? PublishedAt;

        [JsonProperty("assets")]
        public List<ReleaseAsset> Assets;

        [JsonProperty("tarball_url")]
        public string TarballUrl;

        [JsonProperty("zipball_url")]
        public string ZipballUrl;

        [JsonProperty("body")]
        public string Body;
    }
}
