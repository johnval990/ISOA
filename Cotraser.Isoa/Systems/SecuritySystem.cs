using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using Cotraser.Isoa.Common.Security;
using Cotraser.Isoa.Systems.Security;
using Cotraser.Isoa.Common.Exception;
using CommonLibrary.Security;
using Cotraser.Isoa.Domain;

namespace Cotraser.Isoa.Systems
{
    public class SecuritySystem
    {
        private static object _lock = new object();
        static Dictionary<string, SecurityContext> _securityContexts = null;

        public static User GetCurrentUser()
        {
            User currentUser = null;

            if(HttpContext.Current.User.Identity.IsAuthenticated)
                currentUser = new User(HttpContext.Current.User.Identity.Name);

            return currentUser;
        }

        /// <summary>
        /// Ingreso de uario al sistema.
        /// </summary>
        /// <param name="UserName">Nombre de Usuario</param>
        /// <param name="Password">Contraseña</param>
        public static void LoginUser(string UserName, string Password)
        {
            SecurityContext securityContext = SecuritySystem.GetSecurityContextByUserName(UserName);

            if (securityContext != null)
            {
                if (!securityContext.User.IsActive)
                    throw new UserNotExistException();
                
                string clearPassword = Common.Security.CryptographySystem.Decript(securityContext.User.Password);
                if (clearPassword == Password)
                {
                    AuthenticationService authenticationService = new AuthenticationService();
                    List<string> listaRoles = new List<string>();

                    foreach (string idRol in securityContext.UserRoles.Keys)
                    {
                        listaRoles.Add(idRol);
                    }

                    authenticationService.Login(securityContext.User.IdUser.ToString(), listaRoles.ToArray());
                }
                else
                {
                    throw new InvalidPasswordException();
                }
            }
            else
            {
                throw new UserNotExistException();
            }
        }

        /// <summary>
        /// SignOut User
        /// </summary>
        public static void SignOutUser()
        {
            AuthenticationService authenticationService = new AuthenticationService();
            authenticationService.SignOut();
        }

        /// <summary>
        /// Valida si el usuario tiene permisos en un nodo del SiteMap.
        /// </summary>
        /// <param name="mapNode">Nodo del Sitemap</param>
        public static bool ValidateUserRoles(SiteMapNode mapNode)
        {
            bool sw = false;

            foreach (string item in mapNode.Roles)
            {
                if(item == "*")
                    sw = true;
                else if (HttpContext.Current.User.IsInRole(item))
                    sw = true;
            }

            return sw;
        }

        /// <summary>
        /// Obtiene el contexto de seguridad dado el nombre de usuario.
        /// </summary>
        /// <param name="userName">Nombre de Usuario</param>
        /// <returns>Contexto de Seguridad</returns>
        public static SecurityContext GetSecurityContextByUserName(string userName)
        {
            Domain.User securityUser = UserService.GetByUserName(userName);
            if (securityUser == null)
                throw new UserNotExistException();

            Dictionary<string, string> userRoles = UserService.GetUserRoles(securityUser.IdUser);
            Dictionary<string, string> userAreas = UserService.GetUserAreas(securityUser.IdUser);

            SecurityContext securityContext = new SecurityContext(securityUser, userRoles, userAreas);

            if (_securityContexts == null)
                _securityContexts = new Dictionary<string, SecurityContext>();

            if (!_securityContexts.ContainsKey(securityUser.IdUser.ToString()))
            {
                lock (_lock)
                {
                    _securityContexts.Add(securityUser.IdUser.ToString(), securityContext);
                }
            }
            else
                _securityContexts[securityUser.IdUser.ToString()] = securityContext;

            return securityContext;
        }

        /// <summary>
        /// Obtiene el contexto de seguridad dado el guid.
        /// </summary>
        /// <param name="userId">Id del usuario</param>
        /// <returns>Contexto de Seguridad</returns>
        public static SecurityContext GetSecurityContextByUserGuid(int userId)
        {
            if (_securityContexts == null)
                _securityContexts = new Dictionary<string, SecurityContext>();

            if (!_securityContexts.ContainsKey(userId.ToString()))
            {
                lock (_lock)
                {
                    Domain.User securityUser = new Domain.User(userId);

                    if (securityUser == null)
                        throw new UserNotExistException();

                    Dictionary<string, string> userRoles = UserService.GetUserRoles(securityUser.IdUser);
                    Dictionary<string, string> userAreas = UserService.GetUserAreas(securityUser.IdUser);

                    SecurityContext securityContext = new SecurityContext(securityUser, userRoles, userAreas);

                    _securityContexts.Add(securityUser.IdUser.ToString(), securityContext);
                    return securityContext;
                }
            }
            else
                return _securityContexts[userId.ToString()];
        }

        /// <summary>
        /// Retorna la lista de usuarios de la plataforma.
        /// </summary>
        /// <returns></returns>
        public static List<Domain.User> GetAllUsers()
        {
            return UserService.GetAllUsers();
        }
    }
}
