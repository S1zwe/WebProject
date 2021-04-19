using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using S_Interior.FinalService;
namespace S_Interior
{
    public partial class log : System.Web.UI.Page
    {
        FunctionsClient sr = new FunctionsClient();
        protected void Page_Load(object sender, EventArgs e)
        {
           if(Session["Out"] != null)
            {
                Session["Out"] =null; 
                Response.Redirect("modernshop.aspx");
            }
           
        }

        protected void btnLog_Click(object sender, EventArgs e)
        {
            string stremail = Email.Value;
            string pasword = pass.Value;
            string loged = sr.loginUser(stremail, pasword);
            if (loged == "admin")
            {
                Session["Admin"] = true;
                Session["tempID"] = null;
                Session["Email"] = stremail;
                Session["tempUser"] = null;
                Session["Login"] = true;
                Response.Redirect("admin/admin.aspx");
            }
            else if (loged == "modern")
            {
                Session["tempUser"] = null;
                Session["Email"] = stremail;
                Session["tempID"] = null;
                Session["Login"] = true;
                Session["Modern"] = true;
                Session["Vintage"] = null;
                Session["Smart"] = null;
                Session["Living"] = null;
                Session["Bed"] = null;
                Session["Kitchen"] = null;
                Response.Redirect("logedUserFirstLoad.aspx");
            }
            else if (loged == "vintage")
            {
                Session["tempUser"] = null;
                Session["Email"] = stremail;
                Session["tempID"] = null;
                Session["Login"] = true;
                Session["Modern"] = null;
                Session["Vintage"] = true;
                Session["Smart"] = null;
                Session["Living"] = null;
                Session["Bed"] = null;
                Session["Kitchen"] = null;
                Response.Redirect("logedUserFirstLoad.aspx");
            }
            else if (loged == "smart")
            {
                Session["tempUser"] = null;
                Session["Email"] = stremail;
                Session["tempID"] = null;
                Session["Vintage"] = null;
                Session["Login"] = true;
                Session["Modern"] = null;
                Session["Smart"] = true;
                Session["Living"] = null;
                Session["Bed"] = null;
                Session["Kitchen"] = null;
                Response.Redirect("logedUserFirstLoad.aspx");
            }
        }
    }
}