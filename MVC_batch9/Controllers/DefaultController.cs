using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_batch9.Models;
using MVC_batch9.HFilter;
namespace MVC_batch9.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default

        public string GetData(int? id, int name)
        {
            return "hello World! for " + id + "," + name;//+Request.QueryString["name"];
        }

        public int getmeId()
        {

            return 1211;
        }

        public ViewResult getMeView()
        {
            return View();
        }

        [Route("toy/gun")]
        [Route("toy/WaterGun")]
        public ActionResult getMeView1(int id)
        {
            if (id == 1)
                return Content("hello");
            else
                return View("hello");

        }











        public ActionResult Index()
        {

            return View();
        }


        [NonAction]
        public int add(int a, int b)
        {
            return a + b;
        }

        public ActionResult SendData(EmployeeModel emsuba)
        {
            EmployeeModel emp = (EmployeeModel)TempData["Data"];

            TempData.Keep();
            //ViewBag.info = id;

            return View();

        }


        public ViewResult SendDataforOneObject()
        {
            List<EmployeeModel> listobj = new List<EmployeeModel>();

            EmployeeModel emratan = new EmployeeModel();
            emratan.EmpId = 1;
            emratan.EmpSalary = 820000;
            emratan.EmpName = "ratan";

            EmployeeModel emkrishna = new EmployeeModel();
            emkrishna.EmpId = 2;
            emkrishna.EmpSalary = 920000;
            emkrishna.EmpName = "krishna";

            EmployeeModel emsuba = new EmployeeModel();
            emsuba.EmpId = 3;
            emsuba.EmpSalary = 720000;
            emsuba.EmpName = "suba";

            listobj.Add(emratan);
            listobj.Add(emkrishna);
            listobj.Add(emsuba);

            ViewBag.Emp = listobj;

            return View();

        }

        public ViewResult SendDataByUsingModel()
        {

            EmployeeModel emratan = new EmployeeModel();
            emratan.EmpId = 1;
            emratan.EmpSalary = 820000;
            emratan.EmpName = "ratan";

            Department dept = new Models.Department();
            dept.DeptId = 1;
            dept.Deptname = "IT";


            empdept obj = new empdept();
            obj.emp = emratan;
            obj.dept = dept;

            return View(obj);
        }
        public ViewResult SendMultipleDataByUsingModel()
        {

            List<EmployeeModel> listobj = new List<EmployeeModel>();

            EmployeeModel emratan = new EmployeeModel();
            emratan.EmpId = 1;
            emratan.EmpSalary = 820000;
            emratan.EmpName = "ratan";

            EmployeeModel emkrishna = new EmployeeModel();
            emkrishna.EmpId = 2;
            emkrishna.EmpSalary = 920000;
            emkrishna.EmpName = "krishna";

            EmployeeModel emsuba = new EmployeeModel();
            emsuba.EmpId = 3;
            emsuba.EmpSalary = 720000;
            emsuba.EmpName = "suba";

            listobj.Add(emratan);
            listobj.Add(emkrishna);
            listobj.Add(emsuba);

            return View(listobj);
        }

        public PartialViewResult GetMethod()
        {
            EmployeeModel emsuba = new EmployeeModel();
            emsuba.EmpId = 3;
            emsuba.EmpSalary = 720000;
            emsuba.EmpName = "suba";

            return PartialView("_MyPartialView", emsuba);
        }

        public RedirectResult GotoUrl()
        {
            return Redirect("http://www.google.com");
        }
        public RedirectResult GotoUrl2()
        {
            return Redirect("~/Default/SendData");
        }
        public RedirectToRouteResult gotoyourRoute()
        {
            return RedirectToRoute("Default1");
        }

        public RedirectToRouteResult gotoyourActionMethod()
        {
            EmployeeModel emsuba = new EmployeeModel();
            emsuba.EmpId = 3;
            emsuba.EmpSalary = 720000;
            emsuba.EmpName = "suba";
            TempData["Data"] = emsuba;

            return RedirectToAction("SendData", "Default", emsuba);
        }
        public FileResult getmefile()
        {
            return File("~/Web.config", "application/xml", "myFile");
        }
        public ContentResult getcontent(int? id)
        {
            if (id == 1)
            {
                return Content("Hello World");
            }
            else if (id == 2)
            {
                return Content("<p style=color:red>Hello World</p>");
            }
            else
            {
                return Content("<script>alert('Hello world')</script>");

            }
        }

        public JsonResult GetJsonData() {

            EmployeeModel emsuba = new EmployeeModel();
            emsuba.EmpId = 3;
            emsuba.EmpSalary = 720000;
            emsuba.EmpName = "suba";

            return Json(emsuba, JsonRequestBehavior.AllowGet);
        }

        [MyFilter]
        public ActionResult getPlayer() {
            
            ViewBag.Player = "MS Dhoni";
            return View();
        }

    }
}