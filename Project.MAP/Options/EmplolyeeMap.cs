using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
    public class EmplolyeeMap:BaseMap<Employee>
    {
        public EmplolyeeMap()
        {
            Property(x => x.FirstName).HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.LastName).HasColumnType("nvarchar").HasMaxLength(50);
        }
    }
}
