using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using S_Interior.FinalService;

namespace S_Interior
{
    public partial class aboutdesign : System.Web.UI.Page
    {
        FunctionsClient sr = new FunctionsClient();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            
            string Display = "";
            string displatF = "";
            string filepart = "img/blog/";
            string extention = ".jpg";
            string fpath = "img/product/";
            if (Session["Email"] != null && Session["UserID"] != null && IsPostBack)
            {
                
                    dynamic interformDesign = sr.getAboutInterior(Convert.ToInt16(Session["InteriorID"]));
                    foreach (InteriorTable p in interformDesign)
                    {
                        Display += "" +
                        "<div class='blog-img'>" +
                        "<img alt='' src='" + filepart + p.Image + extention + "'>" +
                        "</div>" +
                        "<div class='blog-info'>" +
                        "<h3 class='title'>" + p.Description + "</h3>" +
                        "<div class='blog-meta'>" +
                        "<span ><a href='#' ><i class='fa fa-user'></i>Designer</a></span>" +
                        "<span ><a><i class='fa fa-eye'></i> views(119)</a></span>" +
                        "</div>" +
                        "<p>" + p.RoomType + "</p>" +
                        "<p>" + p.DesignType + "</p>" +
                        "<blockquote>" +
                        "<p>R:" + p.TotalPrice + "</p>" +
                        "</blockquote>" +
                        "<p> Lorem ipsum dolor</p>" +
                        "<p> Fusce </p>" +
                        "</div>";
                    }

                    myabout.InnerHtml = Display;
                    
                    dynamic furniDesign = sr.listFuniture(Convert.ToInt16(Session["InteriorID"]));
                    // dynamic furni = sr.listFuniture(3);
                    foreach (FurnitureTable f in furniDesign)
                    {
                        displatF += "<div class='col-lg-4 col-md-6 col-sm-4 col-xs-6 col-xs-wide mb-40'>" + "<div class='product-item text-center'>";
                        displatF += "<div class='product-img'>";
                        displatF += "<a class='image' href='#'><img src='" + fpath + f.Image + extention + "' alt=''/></a>";
                        displatF += "<a href ='addtocart.aspx?FurID=" + f.furnitureID + "'class='add-to-cart'>add to cart</a>";
                        displatF += "<div class='action-btn fix'>";
                        displatF += "<a href='#' data-toggle='modal'  data-target='#productModal' title='Quickview'><i class='pe-7s-look'></i></a>";
                        displatF += "</div>";
                        displatF += "</div>";
                        displatF += "<div class='product-info'>";
                        displatF += "<h5 class='title'><a href='#'>" + f.Name + "</a></h5>";
                        displatF += "<h5 class='title'><a href='#'>" + f.Description + "</a></h5>";
                        displatF += "<span class='price'><span class='new'>R" + Math.Round(f.Price, 2) + "</span></span>";
                        displatF += "</div>";
                        displatF += "</div>";
                        displatF += "</div>";
                    }
                    furtnitureList.InnerHtml = displatF;
                    Session["Cart"] = true;
            }
                else if (Session["Email"] != null  && !IsPostBack)
                {
                Session["InteriorID"] = Convert.ToInt16(Request.QueryString["funID"]);
                dynamic inter = sr.getAboutInterior(Convert.ToInt32(Request.QueryString["funID"]));
                    Session["UserID"] = sr.getUserID(Convert.ToString(Session["Email"]));
                    foreach (InteriorTable p in inter)
                    {
                        Display += 
                        "<div class='blog-img'>" +
                        "<img alt='' src='" + filepart + p.Image + extention + "'>" +
                        "</div>" +
                        "<div class='blog-info'>" +
                        "<h3 class='title'>" + p.Description + "</h3>" +
                        "<div class='blog-meta'>" +
                        "<span ><a href='#' ><i class='fa fa-user'></i>Designer</a></span>" +
                        "<span ><a><i class='fa fa-eye'></i> views(119)</a></span>" +
                        "</div>" +
                        "<p>" + p.RoomType + "</p>" +
                        "<p>" + p.DesignType + "</p>" +
                        "<blockquote>" +
                        "<p>R:" + p.TotalPrice + "</p>" +
                        "</blockquote>" +
                        "<p> Lorem ipsum dolor</p>" +
                        "<p> Fusce </p>" +
                        "</div>";
                    }

                    myabout.InnerHtml = Display;

                    dynamic furni = sr.listFuniture(Convert.ToInt32(Request.QueryString["funID"]));
               

                foreach (FurnitureTable f in furni)
                    {
                        displatF += "<div class='col-lg-4 col-md-6 col-sm-4 col-xs-6 col-xs-wide mb-40'>" + "<div class='product-item text-center'>";
                        displatF += "<div class='product-img'>";
                        displatF += "<a class='image' href='#'><img src='" + fpath + f.Image + extention + "' alt=''/></a>";
                        displatF += "<a href ='addtocart.aspx?FurID=" + f.furnitureID + "'class='add-to-cart'>add to cart</a>";
                        displatF += "<div class='action-btn fix'>";
                        displatF += "<a href='#' data-toggle='modal'  data-target='#productModal' title='Quickview'><i class='pe-7s-look'></i></a>";
                        displatF += "</div>";
                        displatF += "</div>";
                        displatF += "<div class='product-info'>";
                        displatF += "<h5 class='title'><a href='#'>" + f.Name + "</a></h5>";
                        displatF += "<h5 class='title'><a href='#'>" + f.Description + "</a></h5>";
                        displatF += "<span class='price'><span class='new'>R" + Math.Round(f.Price, 2) + "</span></span>";
                        displatF += "<h5 class='title'><a href='#'>Only " + f.Quantity + " left</a></h5>";
                        displatF += "</div>";
                        displatF += "</div>";
                        displatF += "</div>";
                        Session["furID"] = f.furnitureID;
                    }
                    furtnitureList.InnerHtml = displatF;
                   Session["Cart"] = true;
                  
            }
            else 
                {
                
                Session["InteriorID"] = Convert.ToInt16(Request.QueryString["funID"]);
                dynamic inter = sr.getAboutInterior(Convert.ToInt32(Request.QueryString["funID"]));
                foreach (InteriorTable p in inter)
                {
                    Display +=
                    "<div class='blog-img'>" +
                    "<img alt='' src='" + filepart + p.Image + extention + "'>" +
                    "</div>" +
                    "<div class='blog-info'>" +
                    "<h3 class='title'>" + p.Description + "</h3>" +
                    "<div class='blog-meta'>" +
                    "<span ><a href='#' ><i class='fa fa-user'></i>Designer</a></span>" +
                    "<span ><a><i class='fa fa-eye'></i> views(119)</a></span>" +
                    "</div>" +
                    "<p>" + p.RoomType + "</p>" +
                    "<p>" + p.DesignType + "</p>" +
                    "<blockquote>" +
                    "<p>R:" + p.TotalPrice + "</p>" +
                    "</blockquote>" +
                    "<p> Lorem ipsum dolor</p>" +
                    "<p></p>" +
                    "</div>";
                }

                myabout.InnerHtml = Display;

                dynamic furni = sr.listFuniture(Convert.ToInt32(Request.QueryString["funID"]));


                foreach (FurnitureTable f in furni)
                {
                    displatF += "<div class='col-lg-4 col-md-6 col-sm-4 col-xs-6 col-xs-wide mb-40'>" + "<div class='product-item text-center'>";
                    displatF += "<div class='product-img'>";
                    displatF += "<a class='image' href='#'><img src='" + fpath + f.Image + extention + "' alt=''/></a>";
                    displatF += "<a href ='addtocart.aspx?FurID=" + f.furnitureID + "'class='add-to-cart'>Add To Cart</a>";
                    displatF += "<div class='action-btn fix'>";
                    displatF += "<a href='#' data-toggle='modal'  data-target='#productModal' title='Quickview'><i class='pe-7s-look'></i></a>";
                    displatF += "</div>";
                    displatF += "</div>";
                    displatF += "<div class='product-info'>";
                    displatF += "<h5 class='title'><a href='#'>" + f.Name + "</a></h5>";
                    displatF += "<h5 class='title'><a href='#'>" + f.Description + "</a></h5>";
                    displatF += "<span class='price'><span class='new'>R" + Math.Round(f.Price, 2) + "</span></span>";
                    displatF += "<h5 class='title'><a href='#'>Only " + f.Quantity + " left</a></h5>";
                    displatF += "</div>";
                    displatF += "</div>";
                    displatF += "</div>";
                    Session["furID"] = f.furnitureID;
                }
                furtnitureList.InnerHtml = displatF;
                Session["Cart"] = true;

            }
        }
        }
    
}