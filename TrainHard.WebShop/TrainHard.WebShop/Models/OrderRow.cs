using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrainHard.WebShop.Models
{
    public class OrderRow
    {
        [Key]
        public int Id { get; set; }
        public int Quantity { get; set; }
        public string Size { get; set; }

        //skapar upp en lista med produkter och ordrar som kopplas samman med orderrads id id, som är key i denna klass.
        public virtual Product Product { get; set; }
        public virtual Order Order { get; set; }
    }
}