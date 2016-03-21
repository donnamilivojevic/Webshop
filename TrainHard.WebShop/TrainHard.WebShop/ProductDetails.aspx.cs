using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TrainHard.WebShop.Models;

namespace TrainHard.WebShop
{
    public partial class ProductDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Skapar upp en variabel som begär efter produktId
            int productId = int.Parse(Request["productId"]);

            //Skapar upp en ny lista av produkter där produktId är det första som söks efter
            Contexts.TrainHard context = new Contexts.TrainHard();
            Product product = context.Products.First(p => p.Id == productId);

            //Skriver sedan ut produktnamnet och beskrivningen som är kopplat till en specifika produktId
            productName.Text = product.ProductName;
            productDescription.Text = product.ProductDescription;

            //Spearerar värdena från varandra
            Sizes.DataSource = product.ProductSize.Split(',');
            Sizes.DataBind();
        }

        protected void buyButton_Click(object sender, EventArgs e)
        {     
            //Skapar upp en ny variabel där den begär produktens id      
            int productId = int.Parse(Request["productId"]);
            //Om orderraden är lika med null
            if (Session["TrainHard.Webshop.OrderRow"] == null)              
             {
                //Så går den igenom biblioteket och skapar upp en ny order rad där produktens värden har lagts till
                Dictionary<int, Dictionary<string, int>> p = new Dictionary<int, Dictionary<string, int>>();
                p.Add(productId, new Dictionary<string, int>());
                p[productId].Add(Sizes.SelectedValue, int.Parse(Quantities.SelectedValue));
                Session.Add("TrainHard.Webshop.OrderRow", p);
            }
            else
            {
                // Det finns redan en dictionary i Session
                Dictionary<int, Dictionary<string, int>> p = Session["TrainHard.Webshop.OrderRow"] as Dictionary<int, Dictionary<string, int>>;

                // Kontrollera om productId finns
                if (p.ContainsKey(productId))
                {
                    // Kontrollera om storleken redan finns
                    if (p[productId].ContainsKey(Sizes.SelectedValue))
                    {
                        // I sådana fall lägg till antalet produkter
                        p[productId][Sizes.SelectedValue] += int.Parse(Quantities.SelectedValue);
                    }
                    else
                    {
                        // Annars, lägg till en ny storlek tillsammans med antalet
                        p[productId].Add(Sizes.SelectedValue, int.Parse(Quantities.SelectedValue));
                    }
                }
                else
                {
                    // Om produkten inte fanns, lägg till den
                    p.Add(productId, new Dictionary<string, int>());
                    p[productId].Add(Sizes.SelectedValue, int.Parse(Quantities.SelectedValue));
                }

                Session["TrainHard.Webshop.OrderRow"] = p;
            }
        }
    }
}



