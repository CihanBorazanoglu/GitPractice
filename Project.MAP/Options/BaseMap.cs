using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.ENTITIES.Models;

namespace Project.MAP.Options
{
    public abstract class BaseMap<T>:EntityTypeConfiguration<T> where T : BaseEntity
    {
        public BaseMap()
        {
            Property(x => x.CreatedDate).HasColumnType("datetime");
            Property(x => x.DeletedDate).HasColumnType("datetime");
            Property(x => x.UpdateDate).HasColumnType("datetime");

        }
    }
}
