using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppStudent.Areas.Admin.Controllers
{
    public class AdminToolsController : Controller
    {
        // GET: Admin/AdminTools
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetTools()
        {
            return View();
        }
    }
}