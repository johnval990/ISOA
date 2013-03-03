using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cotraser.Isoa.Domain
{
    public partial class User
    {
        public static List<Area> GetAreasListByUser(int IdUser)
        {
            SubSonic.SqlQuery currentSelect = new SubSonic.Select()
                        .From(Area.Schema)
                        .InnerJoin(UserByArea.IdAreaColumn, Area.IdAreaColumn)
                        .Where(UserByArea.IdUserColumn).IsEqualTo(IdUser)
                        .OrderAsc(Area.Columns.Description);

            return currentSelect.ExecuteTypedList<Area>();
        }

        public static void SaveAreasByUser(int IdUser, List<int> itemList)
        {
            SubSonic.SqlQuery currentDelete = new SubSonic.Delete()
                        .From(UserByArea.Schema)
                        .Where(UserByArea.IdUserColumn).IsEqualTo(IdUser);
            currentDelete.Execute();

            foreach (int item in itemList)
            {
                UserByArea newUserArea = new UserByArea();
                newUserArea.IdUser = IdUser;
                newUserArea.IdArea = item;
                newUserArea.Save();
            }
        }

        public static void DeleteAllCampaignsByUser(int IdUser)
        {
            SubSonic.SqlQuery currentDelete = new SubSonic.Delete()
                        .From(UserByArea.Schema)
                        .Where(UserByArea.IdUserColumn).IsEqualTo(IdUser);
            currentDelete.Execute();
        }

        public static List<AplicationRole> GetRolesListByUser(int IdUser)
        {
            SubSonic.SqlQuery currentSelect = new SubSonic.Select()
                        .From(AplicationRole.Schema)
                        .InnerJoin(UserByRole.IdAplicationRoleColumn, AplicationRole.IdAplicationRoleColumn)
                        .Where(UserByRole.IdUserColumn).IsEqualTo(IdUser)
                        .OrderAsc(AplicationRole.Columns.Description);

            return currentSelect.ExecuteTypedList<AplicationRole>();
        }

        public static void SaveRolesByUser(int IdUser, List<int> itemList)
        {
            SubSonic.SqlQuery currentDelete = new SubSonic.Delete()
                        .From(UserByRole.Schema)
                        .Where(UserByRole.IdUserColumn).IsEqualTo(IdUser);
            currentDelete.Execute();

            foreach (int item in itemList)
            {
                UserByRole newUserRole = new UserByRole();
                newUserRole.IdUserByRole = IdUser;
                newUserRole.IdAplicationRole = item;
                newUserRole.Save();
            }
        }

        public static void DeleteAllRolesByUser(string IdUser)
        {
            SubSonic.SqlQuery currentDelete = new SubSonic.Delete()
                        .From(UserByRole.Schema)
                        .Where(UserByRole.IdUserColumn).IsEqualTo(IdUser);
            currentDelete.Execute();
        }
    }
}
