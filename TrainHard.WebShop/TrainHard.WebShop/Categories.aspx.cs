using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TrainHard.WebShop.Models;

namespace TrainHard.WebShop
{
    public partial class Categories : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                // Hitta kategori-id
                int categoryId = int.Parse(Request["categoryId"]);

                //var context = new Contexts.TrainHard();
                //Skapar upp en ny klass av en lista av producter där det ska sökas efter kategori Id som tillhör den specifika produkten
                TrainHard.WebShop.Contexts.TrainHard context = new Contexts.TrainHard();
                List<Product> products = context.Products.Where(p => p.Category.Id == categoryId).ToList();

                //Binder samman listan med databasen där prodkterna är indelade i kategorier
                productsRepeater.DataSource = products; // Hämtar data information som fyller i listan
                productsRepeater.DataBind(); //Binder samman all data information till den specifika datakällan
            }
        }

        protected void moreInfo_Click(object sender, EventArgs e)
        {
            Button moreInfo = sender as Button;  //Skapar upp funktionen Button där när man klickar på knappen så skickas man vidare till produkt sidan där man finner mer info om produkterna som finns på hemsidan

            Response.Redirect("ProductDetails.aspx?productId=" + moreInfo.CommandArgument); //Vidarbefordrar till en ny url sida när man använder sig av mer info knapps funktionen
        }


    }
}
