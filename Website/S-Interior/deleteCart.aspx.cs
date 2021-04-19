using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using S_Interior.FinalService;

namespace S_Interior
{
    public partial class deleteCart : System.Web.UI.Page
    {
        FunctionsClient sr = new FunctionsClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["DeleteCart"] != null && Session["Login"] != null && Session["Email"] != null )
            {
                int uID = Convert.ToInt16(Session["UserID"]);
                dynamic furnitures = sr.listCart(uID);

                int usID = sr.getUserID(Convert.ToString(Session["Email"]));
                int furniture = Convert.ToInt16(Request.QueryString["FurID"]);
                if (furniture == 0)
                {
                    Response.Redirect("login.aspx");
                    Session["Cart"] = null;
                }
                else
                {


                    dynamic deleted = sr.deleteCartFurniture(usID, furniture);
                    if (deleted == true)
                    {
                        Session["DeleteCart"] = null;
                        Response.Redirect("moderncart.aspx");
                    }
                    else
                    {
                        Session["DeleteCart"] = null;
                        Response.Redirect("login.aspx");
                    }
                }
            }
            else
            {

                int uID = Convert.ToInt16(Session["tempUser"]);
                dynamic furnitures = sr.listTempCart(uID);
                int furniture = Convert.ToInt16(Request.QueryString["FurID"]);
                if (furniture == 0)
                {
                    Response.Redirect("login.aspx");
                    Session["Cart"] = null;
                }
                else
                {


                    dynamic deleted = sr.deleteTempCartFurniture(uID, furniture);
                    if (deleted == true)
                    {
                        Session["DeleteCart"] = null;
                        Response.Redirect("moderncart.aspx");
                    }
                    else
                    {
                        Session["DeleteCart"] = null;
                        Response.Redirect("login.aspx");
                    }
                }
            }


        }
           
        
    }
}