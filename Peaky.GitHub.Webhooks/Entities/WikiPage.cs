using Newtonsoft.Json;

namespace Peaky.GitHub.Webhooks.Entities
{
    public class WikiPage
    {
        /// <summary>
        /// The name of the page.
        /// </summary>
        [JsonProperty("page_name")]
        public string PageName;
        
        /// <summary>
        /// The current page title.
        /// </summary>
        [JsonProperty("title")]
        public string Title;
        
        /// <summary>
        /// The action that was performed on the page. Can be created or edited.
        /// </summary>
        [JsonProperty("action")]
        public string Action;
        
        /// <summary>
        /// The latest commit SHA of the page.
        /// </summary>
        [JsonProperty("sha")]
        public string SHA;
        
        /// <summary>
        /// Points to the HTML wiki page.
        /// </summary>
        [JsonProperty("html_url")]
        public string HtmlUrl;
    }
}
