using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TrainHard.WebShop
{
    public partial class ThankYou : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Skriver ut på web sidan kundens order nummer genom att den begär order id för den specifika beställningen
            OrderInfo.Text = "Ditt ordernummer är: " + Request["orderId"];//
        }
    }
}