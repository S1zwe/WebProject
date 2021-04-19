using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace S_Interior
{
    public partial class changeRoom : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if( Request.QueryString["Room"] != null)
            {
                string room = Convert.ToString(Request.QueryString["Room"]);
                if( room == "Living")
                {
                    Session["Living"] = true;
                    Session["Bed"] = null;
                    Session["Kitchen"] = null;
                    Response.Redirect("modernshop.aspx");
                }
                else if (room =="Bed")
                {
                    Session["Living"] = null;
                    Session["Bed"] = true;
                    Session["Kitchen"] = null;
                    Response.Redirect("modernshop.aspx");
                }
                else
                {
                    Session["Living"] = null;
                    Session["Bed"] = null;
                    Session["Kitchen"] = true;
                    Response.Redirect("modernshop.aspx");
                }
            }
            {
                Response.Redirect("modernshop.aspx");
            }
        }
    }
}