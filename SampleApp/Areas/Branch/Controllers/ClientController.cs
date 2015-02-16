using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleApp.Areas.Branch.Controllers
{
    public class ClientController : Controller
    {
        // GET: Branch/Client
        public ActionResult Index()
        {
            return View();
        }
    }
}