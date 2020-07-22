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

        public string GetData(int? id,int name)
        {
            return "hello World! for " + id + ","+name;//+Request.QueryString["name"];
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

        public ActionResult SendData() {
            int a = 10;

            ViewBag.info = a;

            return View();

        }


        public ActionResult SendDataforOneObject()
        {
            EmployeeModel em = new Models.EmployeeModel();
            em.EmpId = 1;
            em.EmpSalary = 820000;
            em.EmpName = "JAck";

            ViewBag.Emp = em;

                return View();

        }

    }
}