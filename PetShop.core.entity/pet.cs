using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop.core.entity
{
    public class pet // should be upper case "P"...
    {

        public int id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public DateTime birthDate { get; set; }
        public DateTime soldDate { get; set; }
        public string colour { get; set; }
        public string previousOwner { get; set; }
        public double price { get; set; }

    }

    
}
