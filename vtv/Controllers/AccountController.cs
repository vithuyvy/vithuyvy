using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using vtv.Models;

namespace vtv.Controllers
{
    public class AccountController : Controller
    {
        public ViewResult Login (string returnUrl)
        {
            ViewBag.returnUrl = returnUrl;
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Login(AccountModel acc , string returnUrl)
        {
            if (ModelState.IsValid)
            {
                if  (acc.Username == "admin" && acc.Password == "123123")
                {
                    FormsAuthentication.SetAuthCookie(acc.Username, true);
                    return RedirectToLocal(returnUrl);
                }
            }
            return View(acc);
        }

        private ActionResult RedirectToLocal(string returnUrl)
        {
            throw new NotImplementedException();
        }

        public ActionResult Logoff()
        {
            FormsAuthentication.SignOut();
            return RedirectToLocal("Index" , "Home");
        }
        private ActionResult RedirectToLocal(string returnUrl, string v)
        { if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
 
    }
}