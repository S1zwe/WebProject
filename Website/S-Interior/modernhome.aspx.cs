using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using S_Interior.FinalService;

namespace S_Interior
{
    public partial class modernhome : System.Web.UI.Page
    {
        FunctionsClient sr = new FunctionsClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Admin"] == null) {
                if (Session["Email"] != null && Session["Login"] != null)
                {
                    if (Session["Login"] != null)
                    {
                        string emails = Convert.ToString(Session["Email"]);
                        int id = sr.getUserID(emails);
                        Session["UserID"] = id;
                        classUser usr = sr.getCustomer(id);
                        string cat ;
                        if (Session["Vintage"] != null)
                        {
                            cat = "vintage";

                        }
                        else if (Session["Smart"] != null)
                        {
                            cat = "smart";
                        }
                        else if (Session["Modern"] != null)
                        {
                            cat = "modern";
                        }
                        else
                        {
                            cat = usr.farvorite;
                        }
                        classInterior slider = sr.getInterior(cat);
                        string slideDisplay = "";
                        string path = "img/slider/";
                        string extent = ".jpg";
                        slideDisplay += "<img src='" + path + slider.imge + extent + "'>" +
                            "<div class='hero-static-caption'>"
                         + "<div class='container'>"
                         + "<div class='row'>"
                         + "</div>"
                        + "<div class='hero-slider-content col-md-6 col-md-offset-6 col-sm-7 col-sm-offset-5 col-xs-12'>"
                        + "<h4> welcome back " + usr.name + " we missed you</h4>";
                        slideDisplay += "<h1 class='tlt'>";
                        slideDisplay += "<span class='texts'>";
                        slideDisplay += "<span> Interior gallery </span>";
                        slideDisplay += "<span> Interior Fair </span>";
                        slideDisplay += "<span> Interior Shop </span>";
                        slideDisplay += "</span>";
                        slideDisplay += "</h1>";
                        slideDisplay += "<p>-------------------</p>";
                        slideDisplay += "<a href='modernshop.aspx'> Start Shopping </a>";
                        slideDisplay += "</div>";
                        slideDisplay += "</div>";
                        slideDisplay += "</div>";
                        slideDisplay += "</div>";
                        modernSlider.InnerHtml = slideDisplay;


                    }
                    else if (Session["Login"] == null)
                    {
                        string emails = Convert.ToString(Session["Email"]);
                        int id = sr.getUserID(emails);
                        Session["Login"] = null;
                        Session["UserID"] = id;
                        classUser usr = sr.getCustomer(id);
                        string cat ;
                        if(Session["Vintage"] != null)
                        {
                             cat ="vintage";

                        }else if (Session["Smart"] != null)
                        {
                            cat = "smart";
                        }
                        else if (Session["Modern"]  !=null)
                        {
                            cat = "modern";
                        }
                        else
                        {
                            cat = usr.farvorite;
                        }
                        classInterior slider = sr.getInterior(cat);
                        string slideDisplay = "";
                        string path = "img/slider/";
                        string extent = ".jpg";
                        slideDisplay += "<img src='" + path + slider.imge + extent + "'>" +
                            "<div class='hero-static-caption'>"
                         + "<div class='container'>"
                         + "<div class='row'>"
                         + "</div>"
                        + "<div class='hero-slider-content col-md-6 col-md-offset-6 col-sm-7 col-sm-offset-5 col-xs-12'>"
                        + "<h4> welcome back " + usr.name + " we missed you</h4>";
                        slideDisplay += "<h1 class='tlt'>";
                        slideDisplay += "<span class='texts'>";
                        slideDisplay += "<span> Interior gallery </span>";
                        slideDisplay += "<span> Interior Fair </span>";
                        slideDisplay += "<span> Interior Shop </span>";
                        slideDisplay += "</span>";
                        slideDisplay += "</h1>";
                        slideDisplay += "<p>-------------------</p>";
                        slideDisplay += "<a href='modernshop.aspx'> Start Shopping </a>";
                        slideDisplay += "</div>";
                        slideDisplay += "</div>";
                        slideDisplay += "</div>";
                        slideDisplay += "</div>";
                        modernSlider.InnerHtml = slideDisplay;
                    }
                }
                else 
                {
                    
                    string cat;
                    if (Session["Vintage"] != null)
                    {
                        cat = "vintage";

                    }
                    else if (Session["Smart"] != null)
                    {
                        cat = "smart";
                    }
                    else if (Session["Modern"] != null)
                    {
                        cat = "modern";
                    }
                    else
                    {
                        cat = "";
                    }
                    classInterior slider = sr.getInterior(cat);
                    string slideDisplay = "";
                    string path = "img/slider/";
                    string extent = ".jpg";
                    slideDisplay += "<img src='" + path + slider.imge + extent + "'>" +
                        "<div class='hero-static-caption'>"
                     + "<div class='container'>"
                     + "<div class='row'>"
                     + "</div>"
                    + "<div class='hero-slider-content col-md-6 col-md-offset-6 col-sm-7 col-sm-offset-5 col-xs-12'>"
                    + "<h4> welcome </h4>";
                    slideDisplay += "<h1 class='tlt'>";
                    slideDisplay += "<span class='texts'>";
                    slideDisplay += "<span> Interior gallery </span>";
                    slideDisplay += "<span> Interior Fair </span>";
                    slideDisplay += "<span> Interior Shop </span>";
                    slideDisplay += "</span>";
                    slideDisplay += "</h1>";
                    slideDisplay += "<p>-------------------</p>";
                    slideDisplay += "<a href='modernshop.aspx'> Start Shopping </a>";
                    slideDisplay += "</div>";
                    slideDisplay += "</div>";
                    slideDisplay += "</div>";
                    slideDisplay += "</div>";
                    modernSlider.InnerHtml = slideDisplay;
                }
            }
            


               
        }
            
    }
}