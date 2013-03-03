using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cotraser.Isoa.Domain;
using Cotraser.Isoa.Web.UI.Models;
using Cotraser.Isoa.Common.Exception;

namespace Cotraser.Isoa.Web.UI.Controllers
{
    public class AdminController : Controller
    {
        public ActionResult Users()
        {
            return View();
        }

        public ActionResult UserDetail(string id)
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult UserDetail(UserDetailModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    
                }
                catch (Exception e)
                {
                    ExceptionPolicy.HandleException(e);
                    TempData["ErrorMessage"] = "No fue posible realizar el proceso, inténtelo mas tarde.";
                }
            }

            return View(model);
        }
    }
}
