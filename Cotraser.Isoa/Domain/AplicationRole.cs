using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cotraser.Isoa.Domain
{
    public partial class AplicationRole
    {
        public static List<AplicationRole> GetAllRoles()
        {
            AplicationRoleCollection list = new AplicationRoleCollection();
            list.OrderByAsc(AplicationRole.Columns.Description);
            list.Load();

            return list.ToList();
        }
    }
}
