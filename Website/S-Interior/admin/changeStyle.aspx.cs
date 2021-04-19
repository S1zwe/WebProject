using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace S_Interior.admin
{
    public partial class changeStyle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if( Request.QueryString["Style"] !=null)
            {
                string st = Convert.ToString(Request.QueryString["Style"]);
                if(st == "S")
                {
                    Session["Vintage"] = null;
                    Session["Smart"] = true;
                    Session["Modern"] = null;
                    Response.Redirect("interios.aspx");
                }
                else if( st == "V")
                {
                    Session["Vintage"] = true;
                    Session["Smart"] = null;
                    Session["Modern"] = null;
                    Response.Redirect("interios.aspx");
                }
                else
                {
                    Session["Vintage"] = null;
                    Session["Smart"] = true;
                    Session["Modern"] = null;
                    Response.Redirect("interios.aspx");
                }
            }
            else
            {
                Response.Redirect("interios.aspx");
            }
        }
    }
}