using System;
using GitHub.Webhooks.Abstractions;
using GitHub.Webhooks.AspNetCore.Extensions;
using GitHub.Webhooks.Static;
using Microsoft.AspNetCore.Mvc;

namespace GitHub.Webhooks.Example.Controllers
{
    [Route("api/test")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public GitHubWebhookSettings Get()
        {
            return GitHubWebhookSettings.Default;
        }

        [HttpPost]
        public ActionResult Post()
        {
            GitHubEvent evt = HttpContext.Request.GetGitHubEvent();

            Console.WriteLine(evt.GetType().Name + " received");

            return Ok();
        }
    }
}
