using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComputerShop.Models
{
    public class Customer
    {
        //Class data attributes
        public int customerID { get; set; }


        public string firstName { get; set; }

        public string lastName { get; set; }

        public int phoneNumber { get; set; }

        public string emailAddress { get; set; }
    }
}
