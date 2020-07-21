using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_batch9.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default

        public string GetData()
        {
            return "hello World!";
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
    }
}