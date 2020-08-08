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
        // GET: Employee
        public ActionResult Index()
        {
            return View(db.EmployeeModel.ToList());
        }
    }
}