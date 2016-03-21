using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrainHard.WebShop.Models
{
    public class Product
    {
        //Skapar upp en klass för en tabell av produkter som består av olika egenskaper där get/set är en metod som hämtar ut info från
        //databasen och sedan lägger in ny info från aspx sidan till databasen igen med ny info.
        [Key]
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string ProductSize { get; set; }
        public string ProductPrice { get; set; }
        public string ProductWeight { get; set; }
        public string ProductDescription { get; set; } //Egenskaperna som produkterna ska ha med i databasen.

        //skapar upp en lista med categorier och bilder som kopplas samman med produkt id, som är key i denna klass.
        public virtual Category Category { get; set; } //Kopplar ihop relationen mellan product och category i databasen.
        public string Image { get; set; }

      
        
    }
}