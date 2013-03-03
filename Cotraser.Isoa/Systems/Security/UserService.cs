using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cotraser.Isoa.Common.Exception;
using Cotraser.Isoa.Domain;

namespace Cotraser.Isoa.Systems.Security
{
    public class UserService : Domain.User
    {
        public UserService() : base()
        {
        }

        public UserService(string userGuid) : base(userGuid)
        {
        }

        public UserService(string columnName, object columnValue) : base(columnName, columnValue)
        {
        }

        #region [Methods]

            /// <summary>
            /// Obtiene un usuario dado el guid
            /// </summary>
            /// <param name="userName">Nombre de usuario</param>
            /// <returns>Objeto usuario</returns>
            public static UserService GetByUserName(string userName)
            {
                UserService securityUser = new UserService(UserService.Columns.UserName, userName);
                if (securityUser.IsLoaded)
                    return securityUser;
                else
                    throw new UserNotExistException();
            }

            /// <summary>
            /// Almacena los roles asignados al usuario
            /// </summary>
            /// <param name="roleList">Lista de roles</param>
            /// <param name="userId">Id del usuario</param>
            public static void SaveUserRoles(List<int> roleList, int userId)
            {
                try
                {
                    UserService.SaveRolesByUser(userId, roleList);
                }
                catch (Exception ex)
                {
                    ExceptionPolicy.HandleException(ex, false);
                    throw;
                }
            }

            /// <summary>
            /// Almacena las areas asignadas al usuario
            /// </summary>
            /// <param name="areasList">Lista de areas</param>
            /// <param name="userId">Id del usuario</param>
            public static void SaveUserAreas(List<int> areasList, int userId)
            {
                try
                {
                    UserService.SaveAreasByUser(userId, areasList);
                }
                catch (Exception ex)
                {
                    ExceptionPolicy.HandleException(ex, false);
                    throw;
                }
            }

            /// <summary>
            /// Obtiene los roles del usuario
            /// </summary>
            /// <param name="userId">Id del usuario</param>
            /// <returns>LIsta de roles</returns>
            public static Dictionary<string, string> GetUserRoles(int userId)
            {
                Dictionary<string, string> userRoles = new Dictionary<string, string>();
                List<AplicationRole> userRoleCollection = UserService.GetRolesListByUser(userId);

                foreach (AplicationRole item in userRoleCollection)
                {
                    userRoles.Add(item.IdAplicationRole.ToString(), item.Description);
                }

                return userRoles;
            }

            /// <summary>
            /// Obtiene las areas del usuario
            /// </summary>
            /// <param name="userId">Id del usuario</param>
            /// <returns>Lista de areas</returns>
            public static Dictionary<string, string> GetUserAreas(int userId)
            {
                Dictionary<string, string> userCampaigns = new Dictionary<string, string>();
                List<Area> userCampaignCollection = UserService.GetAreasListByUser(userId);

                foreach (Area item in userCampaignCollection)
                {
                    userCampaigns.Add(Convert.ToString(item.IdArea), item.Description);
                }

                return userCampaigns;
            }

            /// <summary>
            /// Retorna la lista de usuarios de la plataforma.
            /// </summary>
            /// <returns></returns>
            public static List<Domain.User> GetAllUsers()
            {
                Domain.UserCollection users = new Domain.UserCollection();
                users.OrderByAsc(Domain.User.Columns.UserName);

                users.Load();
                return users.ToList();
            }

        #endregion
    }
}
