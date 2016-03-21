using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrainHard.WebShop.Models
{
    public class ShoppingBasketItem
    {
        //Skapar upp en klass för en tabell av kundkorgsobjekt som består av olika egenskaper där get/set är en metod som hämtar ut info från
        //databasen och sedan lägger in ny info från aspx sidan till databasen igen med ny info.
        public int Quantity { get; set; }
        public int Size { get; set; } //Egenskaperna som skall kunna väljas till kundkorgen, antal och storlek. 
    }
}