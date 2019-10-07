using System;
using Microsoft.AspNetCore.Mvc;
using Peaky.GitHub.Webhooks.Abstractions;
using Peaky.GitHub.Webhooks.AspNetCore.Extensions;
using Peaky.GitHub.Webhooks.Static;

namespace Peaky.GitHub.Webhooks.Example.Controllers
{
    [Route("github")]
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
