using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace S_Interior
{
    public partial class logOutLoad : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["Login"] = null;
            Session["Email"] = null;
            Session["Modern"] = null;
            Session["Vintage"] = null;
            Session["Smart"] = null;
            Session["Out"] = true;
            Response.Redirect("login.aspx");
        }
    }
}