using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace org.oas.cidh.eVote.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index(string email, string password)
        {
            if(!string.IsNullOrEmpty(email))
                return RedirectToAction("Index", "Home");

            return View();
        }
        
    }
}