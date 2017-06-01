using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMVC.Controllers
{
    public class WorkController : Controller
    {
        // GET: Work
        public ActionResult Index()
        {
            return View();
        }

        // GET: Work/Details/5
        public ActionResult Details(int? idx, int? id)
        {
            ViewBag.Idx = idx;
            ViewBag.Id = id;

            return View();
        }
    }
}
