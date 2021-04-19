using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using S_Interior.FinalService;

namespace S_Interior
{
    public partial class changeShop : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["Shop"] !=null)
            {
 
                string room = Convert.ToString(Request.QueryString["Shop"]);
                if (room =="F")
                {
                    Session["Shop"] =null;
                    Session["Furniture"] = true;
                    Response.Redirect("modernshop.aspx");
                }
                else
                {
                    Session["Shop"] = true;
                    Session["Furniture"] =null;
                    Response.Redirect("modernshop.aspx");
                }  
            }
            {
                Response.Redirect("modernshop.aspx");
            }
        }
    }
}