using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrainHard.WebShop.Models
{
    public class Order
    {
        //Skapar upp en klass för en tabell av ordrar som består av ett olika egenskaper där get/set är en metod som hämtar ut info från
        //databasen och sedan lägger in ny info från aspx sidan till databasen igen med ny info.
        [Key]
        public int Id { get; set; }
        //public int CustomerId { get; set; }
        public int Price { get; set; }
        public DateTime Date { get; set; }

        //skapar upp en lista med kunder som kopplas samman med order id, som är key i denna klass.
        public virtual Customer Customer { get; set; }
    }
}