using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace org.oas.cidh.eVote.Controllers
{
    public class LoginController : Controller
    {
        protected const string EMAIL_ADMIN = "admin.evote@oas.org";
        protected const string EMAIL_COMM = "comm.evote@oas.org";
        protected const string DEAFULT_PASSWORD = "cidh";

        // GET: Login
        public ActionResult Index(string email, string password)
        {
            if (!string.IsNullOrEmpty(email))
            {
                if (email.ToLowerInvariant().Equals(EMAIL_ADMIN.ToLowerInvariant()))
                    return RedirectToAction("Index", "Admin");
                else if (email.ToLowerInvariant().Equals(EMAIL_COMM.ToLowerInvariant()))
                    return RedirectToAction("Index", "Home");
            }

            return View();
        }
        
    }
}