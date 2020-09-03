using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AdonetExample.Models;
using AdonetExample.ServiceReference1;
namespace AdonetExample.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeDetail db = new EmployeeDetail();
        // GET: Employee
        public ActionResult Index()
        {
            WebService1SoapClient obj = new WebService1SoapClient();
            ViewBag.result = obj.Add(19, 20);
            ServiceReference2.Service1Client obj1 = new ServiceReference2.Service1Client();
            ViewBag.result2= obj1.Add(2, 8);
            return View(db.GetEmployee());
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(EmployeeModel EmpObj)
        {
            int i = db.SaveEmployee(EmpObj);

            if (i > 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        [HttpGet]
        public ActionResult Edit(int? id)
        {
            EmployeeModel emp = db.GetEmployeeById(id);

            return View(emp);
        }
        [HttpPost]
        public ActionResult Edit(EmployeeModel obj)
        {
            int i = db.EditEmployee(obj);

            if (i > 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        [HttpGet]
        public ActionResult Delete(int? id)
        {
            EmployeeModel emp = db.GetEmployeeById(id);

            return View(emp);
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int? id)
        {
            int i = db.DeleteEmployee(id);

            if (i > 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }
    }
}