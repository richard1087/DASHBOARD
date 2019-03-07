using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;

namespace CORE.DASHBOARD.Controllers
{
    public class LoginController : Controller
    {
        public ActionResult Index()
        {
            return View("Index");
        }
    }
}
