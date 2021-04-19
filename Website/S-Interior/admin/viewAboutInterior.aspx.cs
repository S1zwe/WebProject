using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace S_Interior.admin
{
    public partial class viewAboutInterior : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Request.QueryString["IntID"] != null)
            {
                Session["IntID"] = Request.QueryString["IntID"];
                Response.Redirect("productedit.aspx");
            }
            else
            {
                Response.Redirect("interios.aspx");
            }
        }
    }
}