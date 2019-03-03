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
        private readonly IStudentService _studentService;

        public StudentController(IDepartmentService departmentService, IStudentService studentService)
        {
            _departmentService = departmentService;
            _studentService = studentService;
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
        public ActionResult InsertStudent(Student student)
        {
            if (student != null)
            {
                student.DepartmentId = int.Parse(Request.Form["DropdownListID"]);
                //return Json(new JavaScriptSerializer().Serialize(student), JsonRequestBehavior.AllowGet);
                _studentService.Insert(student);
                return RedirectToAction("StudentsList", "Student");
            }
            return RedirectToAction(Request.Url.AbsolutePath);
        }

        [HttpGet]
        public ActionResult StudentsList()
        {
            return View(model: _studentService.All());
        }
    }
}