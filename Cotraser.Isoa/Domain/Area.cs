using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cotraser.Isoa.Domain
{
    public partial class Area
    {
        public static List<Area> GetAllAreas()
        {
            AreaCollection list = new AreaCollection();
            list.OrderByAsc(Area.Columns.Description);
            list.Load();

            return list.ToList();
        }
    }
}
