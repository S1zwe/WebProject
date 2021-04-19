using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace S_Interior
{
    public partial class changeStyle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Login"] !=null)
            {
                if (Request.QueryString["Style"] != null)
                {
                    string modern = Convert.ToString(Request.QueryString["Style"]);
                    if (modern == "Smart")
                    {
                       
                        Session["Vintage"] = null;
                        Session["Smart"] = true;
                        Session["Modern"] = null;
                        Response.Redirect("modernshop.aspx");

                    }
                    else if (modern == "Vintage")
                    {
                        Session["Vintage"] = true;
                        Session["Smart"] = null;
                        Session["Modern"] = null;
                        Response.Redirect("modernshop.aspx");
                    }
                    else
                    {
                        Session["Vintage"] = null;
                        Session["Smart"] = null;
                        Session["Modern"] = true;
                        Response.Redirect("modernshop.aspx");
                    }
                }
                else
                {
                    Response.Redirect("modernshop.aspx");
                }
            }
            else
            {
                if (Request.QueryString["Style"] != null)
                {
                    string modern = Convert.ToString(Request.QueryString["Style"]);
                    if (modern == "Smart")
                    {

                        Session["Vintage"] = null;
                        Session["Smart"] = true;
                        Session["Modern"] = null;
                        Response.Redirect("modernshop.aspx");

                    }
                    else if (modern == "Vintage")
                    {
                        Session["Vintage"] = true;
                        Session["Smart"] = null;
                        Session["Modern"] = null;
                        Response.Redirect("modernshop.aspx");
                    }
                    else
                    {
                        Session["Vintage"] = null;
                        Session["Smart"] = null;
                        Session["Modern"] = true;
                        Response.Redirect("modernshop.aspx");
                    }
                }
                else
                {
                    Response.Redirect("modernshop.aspx");
                }
            }
           
            
        }
    }
}