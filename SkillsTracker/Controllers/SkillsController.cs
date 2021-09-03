using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SkillsTracker.Controllers
{

    public class SkillsController : Controller
    {
        // GET: /<controller>/
        //Route: "/skills"
        [HttpGet]
        [Route("/skills")]
        public IActionResult Index()
        {
            string html =
                "<h1>Skills Tracker</h1>" +
                "<h2> Coding skills to learn:</h2>" +
                "<ol>" +
                    "<li>C#</li>" +
                    "<li>JavaScript</li>" +
                    "<li>Python</li>" +
                "</ol>";
            return Content(html, "text/html");
        }

        //Route: "/skills/form"
        //[HttpGet]
        [Route("/skills/form")]
        public IActionResult FormPage()
        {

            string html =
                "<form method='post' action='/skills/form/progress'>"+

                "<label>Date:</label>" +
                "<br><input type='date' name='date' value='mm/dd/yyyy'/>" + //must have variable name. Value must match the one in parameter 

                "<br><label>C#:</label>" +
                    "<br><select name='csharpProgress'>" +
                        "<option value='basic'>" + "Basic" + "</option>" +
                        "<option value='intermediate'>" + "Intermediate" + "</option>" +
                        "<option value='advance'>" + "Advance" + "</option>" +
                    "</select>" +

                "<br><label>JavaScript:</label>" +
                    "<br><select name='jsProgress'>" +
                        "<option value='basic'>" + "Basic" + "</option>" +
                        "<option value='intermediate'>" + "Intermediate" + "</option>" +
                        "<option value='advance'>" + "Advance" + "</option>" +
                    "</select>" +

                "<br><label>Python:</label>" +
                    "<br><select name='pythonProgress'/>" +
                        "<option value='basic'>" + "Basic" + "</option>" +
                        "<option value='intermediate'>" + "Intermediate" + "</option>" +
                        "<option value='advance'>" + "Advance" + "</option>" +
                    "</select>" +

                    "<br><input type='submit' value='submit'/>"+

                    "</form>";

            return Content(html, "text/html");
        }


        //POST: /<controller>form/progress
        //Route: "/skills/form/progress"
        [HttpPost]
        [Route("skills/form/progress")]
        public IActionResult UserProgress(string date, string csharpProgress, string jsProgress, string pythonProgress)
        {

            string html =
                 "<h1>"+ date +"</h1>" +
                 "<ol>" +
                     "<li> C#: "+ csharpProgress + "</li>" +
                     "<li> JavaScript: " + jsProgress + "</li>" +
                     "<li> Python: " + pythonProgress + "</li>" +
                 "</ol>";

            return Content(html, "text/html");
        }
    }
}
