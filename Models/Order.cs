using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace ComputerShop.Models
{
    public class Order
    {
        public int orderID { get; set; }

        public int orderNumber { get; set; }

        // Foreign key   
        //[Display(Name = "Product")]
        //public virtual int productID{ get; set; }

        [ForeignKey("Product")]
        public virtual int productID { get; set; }
        public virtual Product product { get; set; }

        // Foreign key   
        //[Display(Name = "Customer")]
        //public virtual int customerID { get; set; }

        [ForeignKey("Customer")]
        public virtual int customerID { get; set; }
        public virtual Customer customer { get; set; }
    }
}
