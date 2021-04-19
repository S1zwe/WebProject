using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using S_Interior.FinalService;
namespace S_Interior.admin
{
    public partial class sinterios : System.Web.UI.Page
    {
        FunctionsClient sr = new FunctionsClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["Admin"] != null)
            {
                if( Session["Smart"] ==null && Session["Vintage"] == null && Session["Modern"] == null)
                {
                    string product = "";
                    string filepart = "../img/blog/";
                    string extention = ".jpg";
                    dynamic allprod = sr.listDesigns("", "");

                    foreach (InteriorTable dis in allprod)
                    {
                        product += "<div class='col-xl-3 col-sm-6 col-12'>";
                        product += "<div class='product'>";
                        product += "<div class='product-inner'>";
                        product += "<img alt='alt' src='" + filepart + dis.Image + extention + "'>";
                        product += "<div class='cart-btns'>";
                        product += "<a href='viewAboutInterior.aspx?IntID=" + dis.Id + "' class='btn btn-info proedit-btn'>Edit</a>";
                        product += "</div>";
                        product += "</div>";
                        product += "<div class='pro-desc'>";
                        product += "<h5><a href='#'>" + dis.Name + "</a></h5>";
                        product += "<div class='price'>" + dis.TotalPrice + "</div>";
                        product += "</div>";
                        product += "</div>";
                        product += "</div>";
                    }

                    productList.InnerHtml = product;
                }if( Session["Vintage"] !=null)
                {
                    string product = "";
                    string filepart = "../img/blog/";
                    string extention = ".jpg";
                    dynamic allprod = sr.listDesigns("Vintage", "");

                    foreach (InteriorTable dis in allprod)
                    {
                        product += "<div class='col-xl-3 col-sm-6 col-12'>";
                        product += "<div class='product'>";
                        product += "<div class='product-inner'>";
                        product += "<img alt='alt' src='" + filepart + dis.Image + extention + "'>";
                        product += "<div class='cart-btns'>";
                        product += "<a href='viewAboutInterior.aspx?IntID=" + dis.Id + "' class='btn btn-info proedit-btn'>Edit</a>";
                        product += "</div>";
                        product += "</div>";
                        product += "<div class='pro-desc'>";
                        product += "<h5><a href='#'>" + dis.Name + "</a></h5>";
                        product += "<div class='price'>" + dis.TotalPrice + "</div>";
                        product += "</div>";
                        product += "</div>";
                        product += "</div>";
                    }

                    productList.InnerHtml = product;
                }else if( Session["Smart"] != null)
                {
                    string product = "";
                    string filepart = "../img/blog/";
                    string extention = ".jpg";
                    dynamic allprod = sr.listDesigns("Smart", "");

                    foreach (InteriorTable dis in allprod)
                    {
                        product += "<div class='col-xl-3 col-sm-6 col-12'>";
                        product += "<div class='product'>";
                        product += "<div class='product-inner'>";
                        product += "<img alt='alt' src='" + filepart + dis.Image + extention + "'>";
                        product += "<div class='cart-btns'>";
                        product += "<a href='viewAboutInterior.aspx?IntID=" + dis.Id + "' class='btn btn-info proedit-btn'>Edit</a>";
                        product += "</div>";
                        product += "</div>";
                        product += "<div class='pro-desc'>";
                        product += "<h5><a href='#'>" + dis.Name + "</a></h5>";
                        product += "<div class='price'>" + dis.TotalPrice + "</div>";
                        product += "</div>";
                        product += "</div>";
                        product += "</div>";
                    }
                    productList.InnerHtml = product;

                }
                else if (Session["Modern"] != null)
                {
                    string product = "";
                    string filepart = "../img/blog/";
                    string extention = ".jpg";
                    dynamic allprod = sr.listDesigns("Modern", "");

                    foreach (InteriorTable dis in allprod)
                    {
                        product += "<div class='col-xl-3 col-sm-6 col-12'>";
                        product += "<div class='product'>";
                        product += "<div class='product-inner'>";
                        product += "<img alt='alt' src='" + filepart + dis.Image + extention + "'>";
                        product += "<div class='cart-btns'>";
                        product += "<a href='viewAboutInterior.aspx?IntID="+dis.Id+"' class='btn btn-info proedit-btn'>Edit</a>";
                        product += "</div>";
                        product += "</div>";
                        product += "<div class='pro-desc'>";
                        product += "<h5><a href='#'>" + dis.Name + "</a></h5>";
                        product += "<div class='price'>" + dis.TotalPrice + "</div>";
                        product += "</div>";
                        product += "</div>";
                        product += "</div>";
                    }
                    productList.InnerHtml = product;
                }

            }
            else
            {
                Response.Redirect("../login.aspx");
            }
        }
    }
}