using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TrainHard.WebShop.Models;

namespace TrainHard.WebShop
{
    public partial class ShoppingBasket : System.Web.UI.UserControl
    {
        protected override void OnPreRender(EventArgs e)
        {
            //Skapar upp ett bibliotek i session där data från databasen och skapar upp listor av information
            Dictionary<int, Dictionary<string,int>> p = Session["TrainHard.Webshop.OrderRow"] as Dictionary<int, Dictionary<string,int>>; //A library collection of lists that goes thru a session

            if (p != null) //Om p är inte likamed null
            {
                //Skapa upp en variabel
                var context = new TrainHard.WebShop.Contexts.TrainHard(); 

                var numberOfProducts = 0;
                Dictionary<int, Dictionary<string,int>> chosenProducts = new Dictionary<int, Dictionary<string,int>>(); // Söker inom databasen efter valda produkter
                foreach (var kvp in p) // För varje Produkt id i p
                {
                    //För varje size key value pair i key value pair value
                    foreach (var sizeKvp in kvp.Value)
                    {
                        //Så plusar man ihop antaleprodukter med size key value pair value
                        numberOfProducts += sizeKvp.Value;
                    }
                }
                //Visa sedan upp på hemsidan hur många produkter som finns i kundkorgen
                NumberOfItemsInbasket.Text = numberOfProducts.ToString();
                
            }
            else
            { 
                //Om inga produkter finns i kundkorgen så visas denna text
                NumberOfItemsInbasket.Text = "Din kundvagn är tom";
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
    }
}
