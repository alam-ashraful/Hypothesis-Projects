using Experiment.Entities;
using Experiment.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace Experiment_ASP.NET.Controllers
{
    public class StudentController : Controller
    {
        private readonly IDepartmentService _departmentService;

        public StudentController(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }
        
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult CreateStudent()
        {
            // Work with JSON data
            //var json = new JavaScriptSerializer().Serialize(_departmentService.All());
            //return Json(json, JsonRequestBehavior.AllowGet);

            ViewBag.dpLists = new SelectList(_departmentService.All().ToList(), "Id", "Name");
            return View();
        }

        [HttpPost, ActionName("CreateStudent")]
        public ActionResult InsertStudent()
        {
            _departmentService.All();
            return View();
        }
    }
}