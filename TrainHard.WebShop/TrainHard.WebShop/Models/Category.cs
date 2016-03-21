using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrainHard.WebShop.Models
{
    public class Category
    {
        //Skapar upp en klass för en tabell av kategorier som består av ett id nummer samt ett kategorinamn där get/set är en metod som hämtar ut info från
        //databasen och sedan lägger in ny info från aspx sidan till databasen igen med ny info.
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } 

        //skapar upp en lista med produkter som kopplas samman med kategori id, som är key i denna klass.
        public virtual List<Product> Products { get; set; }
    }
}