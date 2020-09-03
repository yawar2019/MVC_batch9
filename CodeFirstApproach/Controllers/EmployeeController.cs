using CodeFirstApproach.Models;
using System;
using System.Collections.Generic;
using System.IO;
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
            ViewBag.Student = new SelectList(dbstud.StudentDetails, "StudId", "StudName", 2);
            return View(obj);
        }

        [HttpPost]
        public ActionResult Index(HttpPostedFileBase fileupload)
        {
            string filename = Path.GetFileName(fileupload.FileName);
            string path = Server.MapPath("~/upload");
            fileupload.SaveAs(Path.Combine(path, filename));
            ViewBag.msg = "uploaded successfully";

            return View();
        }

        public ActionResult ValidationExample()
        {
            return View();
        }

        public ActionResult TestExample()
        {
            //ViewBag.student = "Nagraj";
            //ViewData["Course"] = "MVC";

            TempData["Institute"] = "NareshIT";

            return RedirectToAction("TestExample2");
        }

        public ActionResult TestExample2()
        {
            //string Name = ViewBag.student;
            //string Course = ViewData["Course"].ToString();
            //string InstituteName = Convert.ToString(TempData["Institute"]);
            //TempData.Keep();
            string InstituteName = TempData.Peek("Institute").ToString();
            ViewBag.msg = InstituteName;
            return View();
        }
    }
    }