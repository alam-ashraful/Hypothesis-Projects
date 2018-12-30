using Experiment.Entities;
using Experiment.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Experiment_ASP.NET.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDepartmentService _departmentService;

        public DepartmentController(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }

        [HttpGet]
        public ActionResult GetAllDepartment()
        {
            return View(model: _departmentService.All());
        }

        [HttpGet]
        public ActionResult AddDepartment()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddDepartment(Department department)
        {
            if(department!=null)
            {
                department.CreatedDate = DateTime.UtcNow;
                department.UpdatedDate = DateTime.UtcNow;
                _departmentService.Insert(department);
            }

            return View("GetAllDepartment");
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            var dept = _departmentService.Find(id);
            if (dept != null)
            {
                return View(model: dept);
            }
            else
            {
                return View(Request.UrlReferrer.ToString());
            }
        }
    }
}