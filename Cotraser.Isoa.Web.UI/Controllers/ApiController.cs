using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cotraser.Isoa.Systems.Security;
using Cotraser.Isoa.Web.UI.Models;

namespace Cotraser.Isoa.Web.UI.Controllers
{
    public class ApiController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        public JsonResult GetListUser() 
        {
            List<Domain.User> listUsers = UserService.GetAllUsers();
            List<object> aaData = new List<object>();

            foreach (Domain.User item in listUsers)
            {
                string state = "Inactivo";
                if(item.IsActive)
                    state = "Activo";

                string[] itemData = new string[6] { item.Name, item.UserName, item.Identification, item.Email, state, item.IdUser.ToString() };
                aaData.Add(itemData);
            }

            var output = new Dictionary<string, object>();
            output.Add("aaData", aaData);

            return Json(output);
        }
    }
}
