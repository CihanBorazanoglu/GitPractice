using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Order:BaseEntity
    {
        public string Adress { get; set; }

        public virtual List<ProductOrder> ProductOrders { get; set; }


    }
}
