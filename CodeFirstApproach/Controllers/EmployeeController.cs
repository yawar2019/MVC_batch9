using CodeFirstApproach.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeFirstApproach.Controllers
{
    public class EmployeeController : Controller
    {
        public EmployeeContext db = new EmployeeContext();
        StudentEntities dbstud = new StudentEntities();
        // GET: Employee
        public ActionResult Index()
        {
            return View(db.EmployeeModel.ToList());
        }

        [HttpGet]
        public ActionResult HtmlHelperExample()
        {
            EmployeeModel obj = new Models.EmployeeModel();
            obj.EmpName = "Suba";
            ViewBag.Student = new SelectList(dbstud.StudentDetails, "StudId", "StudName",2);
            return View(obj);
        }
    }
}