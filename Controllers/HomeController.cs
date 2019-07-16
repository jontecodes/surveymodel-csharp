using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using surveymodel.Models;

namespace surveymodel.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            return View("Index");
        }
        //
        [HttpPost("survey")]
        public IActionResult Submission(Survey thisSurvey)
        {
            Survey someSurvey = new Survey()
            {
                Name = thisSurvey.Name,
                Location = thisSurvey.Location
            };
            return View("survey", someSurvey);
        }

    }
}
