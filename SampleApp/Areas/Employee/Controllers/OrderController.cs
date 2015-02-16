using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleApp.Areas.Employee.Controllers
{
    public class OrderController : Controller
    {
        // GET: Employee/Order
        public ActionResult Index()
        {
            return View();
        }
    }
}