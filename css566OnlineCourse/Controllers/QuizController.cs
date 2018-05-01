using System;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using css566OnlineCourse.Models;
using Newtonsoft.Json.Linq;
using System.Linq;
using System.Collections.Generic;

namespace css566OnlineCourse.Controllers
{
    public class QuizController : Controller
    {
        // Request: /Quiz/
        // mapped to /Views/Quiz/Index.cshtml
        public ActionResult Index()
        {
            var questions = GetMultipleChoiceQuestions();
            Console.WriteLine("Questions: " + questions.Count);

            return View(questions);
        }

        private IList<MultipleChoiceQuestion> GetMultipleChoiceQuestions() 
        {
            // Read from file
            string jsonPath = Server.MapPath("~/Content/Samples/mcq.json");
            string input = System.IO.File.ReadAllText(jsonPath);
            JObject quiz = JObject.Parse(input);
            IList<JToken> questions = quiz["quiz"]["scrum"].Children().ToList();
            IList<MultipleChoiceQuestion> mcq = new List<MultipleChoiceQuestion>();
            foreach( JToken q in questions)
            {
                MultipleChoiceQuestion question = q.ToObject<MultipleChoiceQuestion>();
                mcq.Add(question);
            }
            return mcq;
        }

    }
}
