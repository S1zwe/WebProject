using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace S_Interior
{
    public partial class chooseInvoice : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["Login"]!=null && Session["Email"] != null)
            {
               
                if (Request.QueryString["Number"] !=null )
                {
                    Session["Number"] = null;
                    Session["View"] = true;
                    Session["Number"] = Request.QueryString["Number"];
                    Response.Redirect("invoicepage.aspx");
                }
                else
                {
                    Response.Redirect("modernshop.aspx");
                }
            }
            else
            {
                Response.Redirect("login.aspx");
            }
           
        }
    }
}