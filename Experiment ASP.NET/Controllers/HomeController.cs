using Experiment.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Experiment_ASP.NET.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        [HttpGet]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }

        [HttpGet]
        public ActionResult StudentInfo(int id)
        {
            DateTime dt;
            DateTime.TryParse("01-01-1994", out dt);

            var dept1 = new Department()
            {
                Id = 1,
                Name = "CSE"
            };

            var student1 = new Student()
            {
                Id = 1,
                Name = "Md. Ashraful Alam",
                DepartmentId = 1,
                CGPA = 3.36f,
                BirthDate = (dt != null) ? dt : DateTime.Parse("01-01-1990")
            };

            ViewBag.VDepartmentName = dept1.Name;
            return View(student1);
        }

        [HttpGet]
        public ActionResult TestIndex()
        {
            return Content(string.Format("Action name: {0}<br />Controller name: {1}", this.ControllerContext.RouteData.Values["action"].ToString(),
                this.ControllerContext.RouteData.Values["controller"].ToString()));
        }

        [HttpGet]
        public ActionResult Serial(string letterCase)
        {
            var tokens = "SERIAL NUMBER";
            return Content(letterCase =="lower" ? string.Format("tokens: {0}<br />letterCase: {1}", tokens.ToLower(), letterCase) : tokens);
        }
    }
}