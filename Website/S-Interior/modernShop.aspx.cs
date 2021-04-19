using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using S_Interior.FinalService;

namespace S_Interior
{
    public partial class modernShop : System.Web.UI.Page
    {
        FunctionsClient sr = new FunctionsClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            if( Session["Shop"] != null || Session["Furniture"] == null)
            {
                if (Session["Email"] != null && Session["UserID"] != null)
                {

                    string Display = "";
                    string filepart = "img/blog/";
                    string extention = ".jpg";
                    string cat;
                    string room;
                    classUser usr = sr.getCustomer(Convert.ToInt16(Session["UserID"]));
                    if (Session["Living"] != null)
                    {
                        room = "LivingRoom";
                    }
                    else if (Session["Bed"] != null)
                    {
                        room = "Bedroom";
                    }
                    else if (Session["Kitchen"] != null)
                    {
                        room = "Kitchen";
                    }
                    else
                    {
                        room = "";
                    }
                    if (Session["Modern"] != null)
                    {
                        cat = "modern";
                    }
                    else if (Session["Smart"] != null)
                    {
                        cat = "Smart";
                    }
                    else if (Session["Vintage"] != null)
                    {
                        cat = "Vintage";
                    }
                    else
                    {
                        cat = usr.farvorite;
                    }
                    dynamic desigs = sr.liestDesigns(cat, room);
                    foreach (InteriorTable pr in desigs)
                    {

                        Display += "<div class='col-sm-6 col-xs-12 mb-40'>" +
                            "<div class='blog-item'>" +
                            "<a class='image' href='aboutdesign.aspx?funID=" + pr.Id + "'><img src='" + filepart + pr.Image + extention + "' alt=''></a>" +
                            "<div class='blog-dsc'>" +
                            "<span class='date'>" + pr.Date + "</span>" +
                            "<h4 class='title'><a href='#'>" + pr.Description + "</a></h4>" +
                            "<span class='author'>Designed by: <a href='#'> Mary Harper</a></span>" +
                            "</div>" +
                            "</div>" +
                            "</div>";
                    }

                    shopHtml.InnerHtml = Display;
                }
                else if (Session["Email"] != null && Session["UserID"] == null)
                {
                    Session["UserID"] = sr.getUserID(Convert.ToString(Session["Email"]));
                    string Display = "";
                    string filepart = "img/blog/";
                    string extention = ".jpg";
                    string cat;
                    classUser usr = sr.getCustomer(Convert.ToInt16(Session["UserID"]));
                    string room;
                    if (Session["Living"] != null)
                    {
                        room = "LivingRoom";
                    }
                    else if (Session["Bed"] != null)
                    {
                        room = "Bedroom";
                    }
                    else if (Session["Kitchen"] != null)
                    {
                        room = "Kitchen";
                    }
                    else
                    {
                        room = "";
                    }
                    if (Session["Modern"] != null)
                    {
                        cat = "modern";
                    }
                    else if (Session["Smart"] != null)
                    {
                        cat = "Smart";
                    }
                    else if (Session["Vintage"] != null)
                    {
                        cat = "Vintage";
                    }
                    else
                    {
                        cat = usr.farvorite;
                    }
                    dynamic desigs = sr.liestDesigns(cat, room);
                    foreach (InteriorTable pr in desigs)
                    {

                        Display += "<div class='col-sm-6 col-xs-12 mb-40'>"
                        + "<div class='blog-item'>"
                          + "<a class='image' href='aboutdesign.aspx?funID=" + pr.Id + "'><img src='" + filepart + pr.Image + extention + "' alt=''></a>" +
                            "<div class='blog-dsc'>" +
                            "<span class='date'>" + pr.Date + "</span>" +
                            "<h4 class='title'><a href='#'>" + pr.Description + "</a></h4>" +
                            "<span class='author'>Designed by: <a href='#'> Mary Harper</a></span>" +
                            "</div>" +
                            "</div>" +
                            "</div>";
                    }
                    shopHtml.InnerHtml = Display;

                }
                else
                {

                    if (Session["tempUser"] == null)
                    {
                        Session["tempUser"] = sr.addSessionUser();
                    }
                    int tempId = Convert.ToInt16(Session["tempUser"]);
                    Session["Remember"] = tempId;
                    string Display = "";
                    string filepart = "img/blog/";
                    string extention = ".jpg";
                    string cat;
                    string room;
                    if (Session["Living"] != null)
                    {
                        room = "LivingRoom";
                    }
                    else if (Session["Bed"] != null)
                    {
                        room = "Bedroom";
                    }
                    else if (Session["Kitchen"] != null)
                    {
                        room = "Kitchen";
                    }
                    else
                    {
                        room = "";
                    }
                    if (Session["Modern"] != null)
                    {
                        cat = "modern";
                    }
                    else if (Session["Smart"] != null)
                    {
                        cat = "Smart";
                    }
                    else if (Session["Vintage"] != null)
                    {
                        cat = "Vintage";
                    }
                    else
                    {
                        cat = "";
                    }
                    dynamic desigs = sr.liestDesigns(cat, room);
                    foreach (InteriorTable pr in desigs)
                    {

                        Display += "<div class='col-sm-6 col-xs-12 mb-40'>"
                        + "<div class='blog-item'>"
                          + "<a class='image' href='aboutdesign.aspx?funID=" + pr.Id + "'><img src='" + filepart + pr.Image + extention + "' alt=''></a>" +
                            "<div class='blog-dsc'>" +
                            "<span class='date'>" + pr.Date + "</span>" +
                            "<h4 class='title'><a href='#'>" + pr.Description + "</a></h4>" +
                            "<span class='author'>Designed by: <a href='#'> Mary Harper</a></span>" +
                            "</div>" +
                            "</div>" +
                            "</div>";
                    }
                    shopHtml.InnerHtml = Display;
                }

            }
            else
            {
                Response.Redirect("modernshopfurniture.aspx");
            }

        }
    }
}