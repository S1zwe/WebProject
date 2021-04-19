using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using S_Interior.FinalService;
namespace S_Interior
{
    public partial class applyPoints : System.Web.UI.Page
    {
        FunctionsClient sr = new FunctionsClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            if( Session["Email"] != null && Session["Login"]!= null)
            {
                int usrId = sr.getUserID(Convert.ToString(Session["Email"]));
                Session["CouponTotal"] = sr.getPoints(usrId);
                Session["Apply"] = true;
                Response.Redirect("moderncart.aspx");
            }
            else
            {
                Response.Redirect("moderncart.aspx");
            }
        }
    }
}