using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace S_Interior.admin
{
    public partial class changeOderchange : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if( Request.QueryString["Status"] != null)
            {
                string stat = Convert.ToString((Request.QueryString["Status"]));
                if ( stat == "S")
                {
                    Session["Pending"] = null;
                    Session["Shipping"] = true ;
                    Session["All"] = null;
                    Response.Redirect("orders.aspx");
                }
                else if( stat == "P")
                {
                    Session["Pending"] = true;
                    Session["Shipping"] = null;
                    Session["All"] = null;
                    Response.Redirect("orders.aspx");
                }
                else
                {
                    Session["Pending"] = null;
                    Session["Shipping"] = null;
                    Session["All"] = true;
                    Response.Redirect("orders.aspx");
                }
            }
            else
            {
                Response.Redirect("orders.aspx");
            }
        }
    }
}