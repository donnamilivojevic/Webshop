using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TrainHard.WebShop.Models;

namespace TrainHard.WebShop
{
    public partial class ShoppingCart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Dictionary<int, ShoppingCart> p = Session["TrainHard.Webshop.OrderRow"] as Dictionary<int, ShoppingCart>;

            if (p != null)
            {
                var context = new TrainHard.WebShop.Contexts.TrainHard();
                //TrainHard.WebShop.Contexts.TrainHard context = new TrainHard.WebShop.Contexts.TrainHard();
                Dictionary<int, ShoppingCart> chosenProducts = new Dictionary<int, ShoppingCart>();
                foreach (var ProductId in p)
                {
                    Product chosenProduct = context.Products.First(product => product.Id == ProductId.Key);
                    chosenProducts.Add(chosenProduct.Id, ProductId.Value);
                }

                chosenProductsRepeater.DataSource = chosenProducts;
                chosenProductsRepeater.DataBind();
            }
        }
    }
}