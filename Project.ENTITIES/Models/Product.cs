using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Product:BaseEntity
    {
        public string ProductName { get; set; }
        public decimal? UnitPrice { get; set; }

        public int CategoryID { get; set; }

        public virtual List<ProductOrder> ProductOrders { get; set; }

        public virtual Category Category { get; set; }

    }
}
