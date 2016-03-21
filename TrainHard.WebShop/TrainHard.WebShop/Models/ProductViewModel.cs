using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrainHard.WebShop
{
    public class ProductViewModel
    {
        //Skapar upp en klass för en tabell av productViewModel som består av olika egenskaper där get/set är en metod som hämtar ut info från
        //databasen och sedan lägger in ny info från aspx sidan till databasen igen med ny info.
        public string ProductName { get; set; }
        public string ProductSize { get; set; }
        public int Quantity { get; set; }
        public string Image { get; set; }
    }
}