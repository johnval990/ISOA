using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;


using System.Web.Security;
using System.Web.SessionState;

namespace Cotraser.Isoa.Web.UI
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AuthConfig.RegisterAuth();
        }

        //void global_asax_AcquireRequestState(object sender, EventArgs e)
        void Application_AcquireRequestState(object sender, EventArgs e)
        {
            // Code that runs when a new session is started
            // get the security cookie
            HttpCookie cookie = Request.Cookies.Get(FormsAuthentication.FormsCookieName);

            if (cookie != null)
            {
                // we got the cookie, so decrypt the value
                FormsAuthenticationTicket ticket = FormsAuthentication.Decrypt(cookie.Value);

                if (ticket.Expired)
                {
                    // the ticket has expired - force user to login
                    FormsAuthentication.SignOut();
                    //Response.Redirect("~/Security/Login.aspx");
                }
                else
                {
                    // ticket is valid, set HttpContext user value
                    System.IO.MemoryStream buffer = new System.IO.MemoryStream(Convert.FromBase64String(ticket.UserData));
                    System.Runtime.Serialization.Formatters.Binary.BinaryFormatter formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                    HttpContext.Current.User = (System.Security.Principal.IPrincipal)formatter.Deserialize(buffer);
                }
            }
        }
    }
}