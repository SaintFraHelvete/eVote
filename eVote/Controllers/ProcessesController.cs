using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace org.oas.cidh.eVote.Controllers
{
    public class ProcessesController : Controller
    {
        // GET: Processes
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Pending()
        {
            return View();
        }

        public ActionResult Closed()
        {
            return View();
        }

        public ActionResult InProgress()
        {
            return View();
        }
    }
}