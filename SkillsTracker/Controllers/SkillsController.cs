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
        [HttpPost]
        public IActionResult Search()
        {
            string progressTracker = "<option value='1'>Learning basics</option>" +
                "<option value='2'>Making apps</option>" +
                "<option value='3'>Master coder</option>";

            string html = "<form method='post' action='/skills/form'>" +
                "<h2>Date:</h2>" +
                "<input type='date' name='date'/>" +
                "<h2>C#:</h2>" +
                "<select name='csharp'>" +
                    progressTracker +
                "</select>" +
                "<h2>Python:</h2>" +
                "<select name='python'>" +
                    progressTracker +
                "</select>" +
                "<h2>Ruby:</h2>" +
                "<select name='ruby'>" +
                    progressTracker +
                "</select>" +
                "</form>";
            return Content(html, "text/html");
        }
    }
}
