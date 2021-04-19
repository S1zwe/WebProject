using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using S_Interior.FinalService;
namespace S_Interior
{
    public partial class moderneditcart : System.Web.UI.Page
    {
        FunctionsClient sr = new FunctionsClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                if (Session["Email"] != null && Session["Login"] != null)
                {
                    string extention = ".jpg";
                    string fpath = "img/product/";
                    string quant = "";
                    string Display = "";
                    int userId = sr.getUserID(Convert.ToString(Session["Email"]));
                    int id = Convert.ToInt16(Request.QueryString["ID"]);
                    int cart = sr.SearchCart(id, userId);
                    dynamic furni = sr.getAboutFurniture(id);
                    foreach (FurnitureTable f in furni)
                    {

                        Display +=
                        "<div class='blog-img'>" +
                        "<img alt='' src='" + fpath + f.Image + extention + "'>" +
                        "</div>" +
                        "<div class='blog-info'>" +
                        "<h3 class='title'>" + f.Description + "</h3>" +
                        "<div class='blog-meta'>" +
                        "</div>" +
                        "<p>" + f.RoomType + "</p>" +
                        "<blockquote>" +
                        "<p>R:" + f.Price * cart + "</p>" +
                        "</blockquote>" +
                        "<p>Only " + f.Quantity + " left</p>" +
                        "</div>";
                        quant += "</h3><li><h3>Your Quantity(" + cart + ")</h3></li>";
                    }
                    myabout.InnerHtml = Display;
                    ok.InnerHtml = quant;
                    Session["Cart"] = true;


                }
                else
                {
                    string extention = ".jpg";
                    string fpath = "img/product/";
                    string quant = "";
                    string Display = "";
                    int userId = Convert.ToInt16(Session["tempUser"]);
                    int id = Convert.ToInt16(Request.QueryString["ID"]);
                    int cart = sr.SearchTempCart(id, userId);
                    dynamic furni = sr.getAboutFurniture(id);
                    foreach (FurnitureTable f in furni)
                    {

                        Display +=
                        "<div class='blog-img'>" +
                        "<img alt='' src='" + fpath + f.Image + extention + "'>" +
                        "</div>" +
                        "<div class='blog-info'>" +
                        "<h3 class='title'>" + f.Description + "</h3>" +
                        "<div class='blog-meta'>" +
                        "</div>" +
                        "<p>" + f.RoomType + "</p>" +
                        "<blockquote>" +
                        "<p>R:" + f.Price * cart + "</p>" +
                        "</blockquote>" +
                        "<p>Only " + f.Quantity + " left</p>" +
                        "</div>";
                        quant += "</h3><li><h3>Your Quantity(" + cart + ")</h3></li>";
                    }
                    myabout.InnerHtml = Display;
                    ok.InnerHtml = quant;
                    Session["Cart"] = true;

                }
            }
            

           

        }

        protected void btnChange_Click(object sender, EventArgs e)
        {
            if( Session["Email"]!=null && Session["Login"] != null)
            {
                int num = Convert.ToInt16(txtChange.Text);
                int userId = sr.getUserID(Convert.ToString(Session["Email"]));
                int id = Convert.ToInt16(Request.QueryString["ID"]);
                if (num <= 0)
                {
                    bool deleted = sr.deleteCartFurniture(userId, id);
                    if (deleted = true)
                    {
                        Response.Redirect("moderncart.aspx");
                    }
                    else
                    {
                        Response.Redirect("moderneditcart.aspx?ID=" + id);
                    }
                }
                else
                {
                    bool edit = sr.editQuantity(userId, id, num);
                    if (edit == true)
                    {
                        Response.Redirect("moderncart.aspx");
                    }
                    else
                    {
                        Response.Redirect("moderneditcart.aspx?ID=" + id);
                    }
                }
            }else
            {
                int num = Convert.ToInt16(txtChange.Text);
                int userId = Convert.ToInt16(Session["tempUser"]);
                int id = Convert.ToInt16(Request.QueryString["ID"]);
                if (num <= 0)
                {
                    bool deleted = sr.deleteTempCartFurniture(userId, id);
                    if (deleted = true)
                    {
                        Response.Redirect("moderncart.aspx");
                    }
                    else
                    {
                        Response.Redirect("moderneditcart.aspx?ID=" + id);
                    }
                }
                else
                {
                    bool edit = sr.editTempQuantity(userId, id, num);
                    if (edit == true)
                    {
                        Response.Redirect("moderncart.aspx");
                    }
                    else
                    {
                        Response.Redirect("moderneditcart.aspx?ID=" + id);
                    }
                }
            }
            
        }
    }
}