using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SkillsTracker.Controllers
{
    [Route("/skills")]
    public class SkillsController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            string html = "<h1>Skills Tracker</h1>" +
                "<h2>" +
                    "<ol>" +
                        "<li>C Sharp</li>" +
                        "<li>Python</li>" +
                        "<li>Ruby</li>" +
                    "</ol>" +
                "</h2>";
            return Content(html, "text/html");
        }

        [HttpGet("form")]
        
        public IActionResult ProgressTracker()
        {
            string progressTracker = "<option value='Learning basics'>Learning basics</option>" +
                "<option value='Making apps'>Making apps</option>" +
                "<option value='Master coder'>Master coder</option>";

            string html = "<form method='post' action='/skills/form'>" +
                "<h2>Date:</h2>" +
                "<input type='date' name='date'/>" +
                "<h2>C#:</h2>" +
                "<select name='cSharp'>" +
                    progressTracker +
                "</select>" +
                "<h2>Python:</h2>" +
                "<select name='python'>" +
                    progressTracker +
                "</select>" +
                "<h2>Ruby:</h2>" +
                "<select name='ruby'>" +
                    progressTracker +
                "</select>" + "<br><br>" +
                "<input type='submit' value='Log Progress'/>" +
                "</form>";
            return Content(html, "text/html");
        }

        [HttpPost("form")]
        public IActionResult TrackProgress(string date, string cSharp, string python, string ruby)
        {
            string html = $"<h1>{date}</h1>" +
                "<ol>" +
                    $"<li>C#: {cSharp}</li>" +
                    $"<li>Python: {python}</li>" +
                    $"<li>Ruby: {ruby}</li>" +
                "</ol>";
            return Content(html, "text/html");
        }
    }
}
