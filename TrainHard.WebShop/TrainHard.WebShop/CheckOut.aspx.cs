using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TrainHard.WebShop.Models;

namespace TrainHard.WebShop
{
    public partial class CheckOut : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            //Skapar upp ett bibliotek i session där data från databasen och skapar upp listor av information
            //Session möjlig gör så att du kan lagra och hämta värden för en användare medans den anvädaren navigerar sig runt ASP:NET sidorna i en web applikation
            Dictionary<int, Dictionary<string, int>> p = Session["TrainHard.Webshop.OrderRow"] as Dictionary<int, Dictionary<string, int>>;

            if (p != null) //Om p är inte likamed null
            {
                var context = new TrainHard.WebShop.Contexts.TrainHard();

                //Skapar upp ett bibliotek i session där data från databasen och skapar upp listor av information
                //Session möjlig gör så att du kan lagra och hämta värden för en användare medans den anvädaren navigerar sig runt ASP:NET sidorna i en web applikation
                Dictionary<int, Dictionary<string, int>> chosenProductsFromSession = new Dictionary<int, Dictionary<string, int>>(); // Söker inom databasen efter valda produkter
                foreach (var kvp in p) // För varje Produkt id i p
                {
                    var chosenProduct = context.Products.First(product => product.Id == kvp.Key); //Hämtas den första matchande produkten med det produkt id kopplat till den specifika produkten
                    chosenProductsFromSession.Add(chosenProduct.Id, kvp.Value); //Läggs sedan in i kundkorgen
                }

                chosenProductsRepeater.DataSource = chosenProductsFromSession; //Skapar en kontakt med databasen för de valda produkterna
                chosenProductsRepeater.DataBind(); //Binder samman med databasen med produkt tabellen
            }

            int price = 0;
            //Skapar upp en lista i ProductViewModel med valda produkter
            List<ProductViewModel> chosenProducts = new List<ProductViewModel>();
            if (p != null) //Om p inte är lika med null
            {
                TrainHard.WebShop.Contexts.TrainHard context = new TrainHard.WebShop.Contexts.TrainHard(); //Skapar du upp en ny klass 
                List<ProductViewModel> products = new List<ProductViewModel>(); //Med en ny lista av produkter
                foreach (var productId in p)//För varje produkt id i p
                {
                    //Den valda produkten i produkt som har den första matchande produkt id som är likamed produktid.key
                    Product chosenProduct = context.Products.First(product => product.Id == productId.Key);

                    foreach (var item in productId.Value)//För varje objekt i produktid.value. Value = hämtar det värde som är associerat med den specifika objektet
                    {
                        //Du tar priset av den valda produkten och ultiplicerar med det valda pbjektets värde
                        price += int.Parse(chosenProduct.ProductPrice) * item.Value;
                        ProductViewModel product = new ProductViewModel()
                        {
                            //Det valda objektet kommer då visas med produktnamn, produkt strlk, mängden samt en bild av produkten
                            ProductName = chosenProduct.ProductName,
                            ProductSize = item.Key,
                            Quantity = item.Value,
                            Image = chosenProduct.Image
                        };
                        //Lägg till produkten
                        products.Add(product);
                    }
                }
                //Binder samman listan med databasen där de valda produkterna finns i produktlistan
                chosenProductsRepeater.DataSource = products; // Hämtar data information som fyller i listan
                chosenProductsRepeater.DataBind(); //Binder samman all data information till den specifika datakällan
            }
            //Skriver ut den totala summan av alla produkter som finns i kundkorgen
            totalPrice.Text = price.ToString();
        }

        protected void Placeorder_Click(object sender, EventArgs e)
        {
            // Skapar en ny kund med olika värden
            Customer newcustomer = new Customer();
            newcustomer.CustomerName = CustomerName.Text;
            newcustomer.ContactName = ContactName.Text;
            newcustomer.Address = Address.Text;
            newcustomer.PostalCode = PostalCode.Text;
            newcustomer.City = City.Text;
            newcustomer.Country = Country.Text;
            newcustomer.Mail = Mail.Text;

            //För varje ny kund som skapas så lagras dom ny kunderna i databasen
            var context = new TrainHard.WebShop.Contexts.TrainHard();
            var savedCustomer = context.Customers.Add(newcustomer);
            context.SaveChanges();


            // Skapa Order
            var savedOrder = context.Orders.Add(new Order() { Customer = savedCustomer, Date = DateTime.Now });

            // loopa igenom session
            Dictionary<int, Dictionary<string, int>> p = Session["TrainHard.Webshop.OrderRow"] as Dictionary<int, Dictionary<string, int>>;

            if (p == null) //Om p är likamed null
            {
                //Skrivs denna text ut
                Status.Text = "Du har inga produkter i kundkorgen!";
                return;
            }

            int price = 0;
            // För varje KeyValuePair, skapa en orderrad
            foreach (var kvp in p)
            {
                //För varje storleks keyvaluepair i key value pair värde
                foreach (var sizeKvp in kvp.Value)
                {
                   // Skapar upp en ny variabel där den söker efter produktens id nummer
                    var currentProduct = context.Products.First(q => q.Id == kvp.Key);

                     //Skapar upp en ny orderrad 
                    var orderow = new OrderRow();
                    orderow.Order = savedOrder;
                    orderow.Product = currentProduct;
                    orderow.Quantity = sizeKvp.Value;

                    //Du tar priset av den valda produkten och multiplicerar med orderradens mängd av produkter
                    price += int.Parse(currentProduct.ProductPrice) * orderow.Quantity;

                    //Lägger till den nya orderraden i listan
                    context.OrderRows.Add(orderow);
                }
                context.SaveChanges();
            }

            savedOrder.Price = price;
            context.SaveChanges();

            // Skickar användaren till Tack
            Response.Redirect("ThankYou.aspx?orderId="+savedOrder.Id);
        }
    }
}