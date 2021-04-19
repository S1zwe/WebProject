using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using S_Interior.FinalService;
namespace S_Interior
{
    public partial class modernshopfurniture : System.Web.UI.Page
    {
        FunctionsClient sr = new FunctionsClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            string Display = "";
            string displatF = "";
            string filepart = "img/blog/";
            string extention = ".jpg";
            string fpath = "img/product/";
            if (Session["Shop"] == null && Session["Furniture"] != null)
            {
                if (Session["Email"] != null && Session["UserID"] !=null)
                {

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

                    dynamic furniDesign = sr.listAllFunitures(cat, room);
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
                else
                {
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
                    dynamic furni = sr.listAllFunitures(cat, room);


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
            else
            {
                Response.Redirect("mornshop.aspx");
            }
           
            
        }
    }
}