using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TrainHard.WebShop.Models;

namespace TrainHard.WebShop
{
    public partial class Menu : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) //Om html sidan inte skickas till servern så ska den gör allt det som finns under
            {
                //Skappar upp en ny klass för trainhard produkter där information som finns kan delas vidare till andra sidor inom tfs.
                Contexts.TrainHard context = new Contexts.TrainHard();

                //Skapar upp en lista av kategorierna som produkterna är indelade i
                List<Category> nutritions = new List<Category>(); 
                nutritions.Add(context.Categories.First(c => c.Name == "Proteinpulver"));
                nutritions.Add(context.Categories.First(c => c.Name == "Bars"));
                nutritions.Add(context.Categories.First(c => c.Name == "Aminosyror"));

                //Binder samman listan med databasen där produkterna är indelade i kategorier
                nutritionCategories.DataSource = nutritions; // Hämtar data information som fyller i listan
                nutritionCategories.DataBind(); //Binder samman all data information till den specifika datakällan

                //Skapar upp en ny klass för trainhard produkter där information som finns kan delas vidare till andra sidor inom tfs.
                Contexts.TrainHard p = new Contexts.TrainHard();

                //Skapar upp en lista av kategorierna som produkterna är indelade i 
                List<Category> clothing = new List<Category>(); 
                clothing.Add(context.Categories.First(c => c.Name == "Dam"));
                clothing.Add(context.Categories.First(c => c.Name == "Herr"));

                //Binder samman listan med databasen där prodkterna är indelade i kategorier
                clothingCategories.DataSource = clothing; // Hämtar data information som fyller i listan
                clothingCategories.DataBind(); //Binder samman all data information till den specifika datakällan
            }

        }
    }
}