using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace S_Interior
{
    public partial class myinvoices : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if( Session["Email"] !=null && Session["Login"] != null)
            {
                Session["View"] = true;
                Session["Number"] = null;
                Response.Redirect("invoicepage.aspx");
            }
            else
            {
                Response.Redirect("modernshop.aspx");
            }
        }
    }
}