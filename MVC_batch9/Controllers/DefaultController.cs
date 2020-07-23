using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_batch9.Models;
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

        public ActionResult getMeView()
        {
            return View();
        }

        [Route("toy/gun")]
        [Route("toy/WaterGun")]
        public ActionResult getMeView1()
        {
            return View();
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

        public ActionResult SendData()
        {
            int a = 10;

            ViewBag.info = a;

            return View();

        }


        public ActionResult SendDataforOneObject()
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

        public ActionResult SendDataByUsingModel()
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
        public ActionResult SendMultipleDataByUsingModel()
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
    }
}