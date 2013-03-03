using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cotraser.Isoa.Web.UI.Models;
using Cotraser.Isoa.Common.Security;
using Cotraser.Isoa.Common.Exception;
using Cotraser.Isoa.Systems;

namespace Cotraser.Isoa.Web.UI.Controllers
{
    public class DefaultController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        public ActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    SecuritySystem.LoginUser(model.UserName, model.Password);

                    if(!string.IsNullOrEmpty(returnUrl))
                        return RedirectToLocal(returnUrl);
                    else
                        return RedirectToAction("Index", "Default");
                }
                catch (UserNotExistException)
                {
                    TempData["ErrorMessage"] = "El usuario ingresado no existe o la contraseña de acceso es incorrecta.";
                }
                catch (InvalidPasswordException)
                {
                    TempData["ErrorMessage"] = "El usuario ingresado no existe o la contraseña de acceso es incorrecta.";
                }
                catch (Exception e)
                {
                    ExceptionPolicy.HandleException(e);
                    TempData["ErrorMessage"] = "No fue posible validar el usuario, inténtelo mas tarde.";
                }
            }

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LogOff()
        {
            SecuritySystem.SignOutUser();
            return RedirectToAction("Index", "Default");
        }

        #region Helpers

            private ActionResult RedirectToLocal(string returnUrl)
            {
                if (Url.IsLocalUrl(returnUrl))
                {
                    return Redirect(returnUrl);
                }
                else
                {
                    return RedirectToAction("Index", "Default");
                }
            }

        #endregion
    }
}
