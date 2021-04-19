using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using S_Interior.FinalService;
namespace S_Interior
{
    public partial class Modern : System.Web.UI.MasterPage
    {
        FunctionsClient sr = new FunctionsClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            string loginEmail = Convert.ToString(Session["Email"]);
            if (Session["Email"] == null && Session["Login"] == null)
            {
                // Start header html
                if (Session["tempUser"] == null)
                {
                    Session["tempUser"] = sr.addSessionUser();
                }
                int id =Convert.ToInt16(Session["tempUser"]);
                string strHeader = "";
                int items = 0;
                int totalMoney = 0;
                int countMoney = 0;
                int count = 0;
                countMoney = 0;
                dynamic cartF = sr.listTempCart(id);

                foreach (SessionCart c in cartF)
                {
                    string display = "";
                    dynamic furnt = sr.listCartFuniture(Convert.ToInt16(c.Quantity));
                    foreach (FurnitureTable f in furnt)
                    {
                        countMoney += Convert.ToInt16(f.Price * c.Quantity);
                    }
                    count += Convert.ToInt16(c.Quantity);
                }
                totalMoney += countMoney;
                items = count;
                // logo
                strHeader += "<div class='col-md-2 col-sm-6 col-xs-6'>";
                    strHeader += "<div class='header-logo'>";
                    strHeader += "<a href='modernshop.aspx'><img src='img/logo.png' alt='main logo'></a>";
                    strHeader += "</div>";
                    strHeader += "</div>";
                    //   header-search & total-cart 
                    strHeader += "<div class='col-md-2 col-sm-6 col-xs-6 float-right'>";
                    strHeader += "<div class='header-option-btns float-right'>";
                    //    header Account 
                    strHeader += "<div class='header-account float-left'>";
                    strHeader += "<ul>";
                    strHeader += "<li><a href='login.aspx'><h4>Login</h4></a>";
                    strHeader += "</li>";
                    strHeader += "</ul>";
                    strHeader += "</div>";
                    //     Header Cart 
                    strHeader += "<div class='header-cart float-left'>";
                     //     Cart Toggle
                    strHeader += "<a class='cart-toggle' href='#' data-toggle='dropdown'>";
                    strHeader += "<i class='pe-7s-cart'></i>";
                    strHeader += "<span>" + items + "</span>";
                    strHeader += "</a>";
                    //      Mini Cart Brief
                    strHeader += "<div class='mini-cart-brief dropdown-menu text-left'>";
                    strHeader += "<div class='cart-items'><p>You have  <span>" + items + " items</span> in your shopping bag</p></div>";
                    //      Cart Total
                    strHeader += "<div class='cart-totals'>";
                    strHeader += "<h5>Total <span>R " + Math.Round(Convert.ToDouble(totalMoney), 2) + "</pan></h5>";
                    strHeader += "</div>";
                    //       Cart Button 
                    strHeader += "<div class='cart-bottom  clearfix'>";
                    strHeader += "<a href='moderncart.aspx'>View Items</a>";
                    strHeader += "<a href='moderncart.aspx'> Check Out</a>";
                    strHeader += "</div>";
                    strHeader += "</div>";
                    strHeader += "</div>";
                    strHeader += "</div>";
                    strHeader += "</div>";
                    //        primary-menu
                    strHeader += "<div class='col-md-8 col-xs-12'>";
                    strHeader += "<nav class='main-menu text-center'>";
                    strHeader += "<ul>";
                    strHeader += "<li class='ctive'><a href='modernshop.aspx'>Home</a>";
                    strHeader += "</li>";
                if (Session["Modern"] != null)
                {
                    strHeader += "<li><a href='changeStyle.aspx?Style=Vintage'> Vintage </a>";
                    strHeader += "</li>";
                    strHeader += "<li><a href='changeStyle.aspx?Style=Smart'> Smart </a>";
                    strHeader += "</li>";
                }
                else if(Session["Smart"] != null){
                    strHeader += "<li><a href='changeStyle.aspx?Style=Vintage'> Vintage </a>";
                    strHeader += "</li>";
                    strHeader += "<li><a href='changeStyle.aspx?Style=Modern'>Modern </a>";
                    strHeader += "</li>";
                }
                else if( Session["Vintage"] !=null)
                {
                    strHeader += "<li><a href='changeStyle.aspx?Style=Smart'> Smart </a>";
                    strHeader += "</li>";
                    strHeader += "<li><a href='changeStyle.aspx?Style=Modern'>Modern </a>";
                    strHeader += "</li>";
                }
                else
                {
                    strHeader += "<li><a href='changeStyle.aspx?Style=Modern'> Modern </a>";
                    strHeader += "</li>";
                    strHeader += "<li><a href='changeStyle.aspx?Style=Smart'> Smart </a>";
                    strHeader += "</li>";
                    strHeader += "<li><a href='changeStyle.aspx?Style=Vintage'>Vintage</a>";
                    strHeader += "</li>";
                }
                    strHeader += "</ul>";
                    strHeader += "</nav>";
                    strHeader += "<div class='mobile-menu'></div>";
                    strHeader += "</div>";
                    headerHtml.InnerHtml = strHeader;
                    // end header html
                

            }
            else
            {
                if (Session["Modern"] != null)
                {

                    // Start header html
                    string strHeader = "";

                    int userId = sr.getUserID(Convert.ToString(Session["Email"]));
                    int items = 0;
                    Session["UserID"] = userId;
                    int totalMoney = 0;
                    int countMoney = 0;
                    int count = 0;
                    countMoney = 0;
                    dynamic cartF = sr.listCart(userId);

                    foreach (cartTable c in cartF)
                    {
                        string display = "";
                        dynamic furnt = sr.listCartFuniture(Convert.ToInt16(c.FurnitureID));
                        foreach (FurnitureTable f in furnt)
                        {
                           countMoney += Convert.ToInt16(f.Price * c.FurnitureNumber);
                        }
                        count += Convert.ToInt16(c.FurnitureNumber); 

                    }
                    totalMoney += countMoney;
                    items = count;

                    // logo
                    strHeader += "<div class='col-md-2 col-sm-6 col-xs-6'>";
                    strHeader += "<div class='header-logo'>";
                    strHeader += "<a href='modernshop.aspx'><img src='img/logo.png' alt='main logo'></a>";
                    strHeader += "</div>";
                    strHeader += "</div>";
                    //   header-search & total-cart 
                    strHeader += "<div class='col-md-2 col-sm-6 col-xs-6 float-right'>";
                    strHeader += "<div class='header-option-btns float-right'>";
                    //    header Account 
                    strHeader += "<div class='header-account float-left'>";
                    strHeader += "<ul>";
                    strHeader += "<li><a href='#' data-toggle='dropdown'><i class='pe-7s-config'></i></a>";
                    strHeader += "<ul class='dropdown-menu'>";
                    strHeader += "<li ><a href='#'> My Profile</a></li>";
                    strHeader += "<li ><a href='myinvoices.aspx'>My Invoices</a></li>";
                    strHeader += "<li ><a href='logOutLoad.aspx'> Log out</a></li>";
                    strHeader += "<li ><a href='#'> Deregister</a></li>";
                    strHeader += "</ul>";
                    strHeader += "</li>";
                    strHeader += "</ul>";
                    strHeader += "</div>";
                    //     Header Cart 
                    strHeader += "<div class='header-cart float-left'>";
                    //     Cart Toggle
                    strHeader += "<a class='cart-toggle' href='#' data-toggle='dropdown'>";
                    strHeader += "<i class='pe-7s-cart'></i>";
                    strHeader += "<span>" + items + "</span>";
                    strHeader += "</a>";
                    //      Mini Cart Brief
                    strHeader += "<div class='mini-cart-brief dropdown-menu text-left'>";
                    strHeader += "<div class='cart-items'><p>You have  <span>" + items + " items</span> in your shopping bag</p></div>";
                    //      Cart Total
                    strHeader += "<div class='cart-totals'>";
                    strHeader += "<h5>Total <span>R " + Math.Round(Convert.ToDouble(totalMoney), 2) + "</pan></h5>";
                    strHeader += "</div>";
                    //       Cart Button 
                    strHeader += "<div class='cart-bottom  clearfix'>";
                    strHeader += "<a href='moderncart.aspx'>View Items</a>";
                    strHeader += "<a href='moderncart.aspx'> Check Out</a>";
                    strHeader += "</div>";
                    strHeader += "</div>";
                    strHeader += "</div>";
                    strHeader += "</div>";
                    strHeader += "</div>";
                    //        primary-menu
                    strHeader += "<div class='col-md-8 col-xs-12'>";
                    strHeader += "<nav class='main-menu text-center'>";
                    strHeader += "<ul>";
                    strHeader += "<li class='ctive'><a href='modernshop.aspx'> Home </a>";
                    strHeader += "</li>";
                    strHeader += "<li><a href='changeStyle.aspx?Style=Vintage'>Vintage</a>";
                    strHeader += "</li>";
                    strHeader += "<li><a href='changeStyle.aspx?Style=Smart'>Smart</a>";
                    strHeader += "</li>";
                    strHeader += "</ul>";
                    strHeader += "</nav>";
                    strHeader += "<div class='mobile-menu'></div>";
                    strHeader += "</div>";

                    headerHtml.InnerHtml = strHeader;
                    // end header html

                }
                else if (Session["Smart"] != null)
                {
                    // Start header html
                    string strHeader = "";

                    int userId = sr.getUserID(Convert.ToString(Session["Email"]));
                    int items = 0;
                    Session["UserID"] = userId;
                    int totalMoney = 0;
                    int countMoney = 0;
                    int count = 0;
                    countMoney = 0;
                    dynamic cartF = sr.listCart(userId);

                    foreach (cartTable c in cartF)
                    {
                        string display = "";
                        dynamic furnt = sr.listCartFuniture(Convert.ToInt16(c.FurnitureID));
                        foreach (FurnitureTable f in furnt)
                        {
                            countMoney += Convert.ToInt16(f.Price);
                        }
                        count += Convert.ToInt16(c.FurnitureNumber);

                    }
                    totalMoney += countMoney;
                    items = count;

                    // logo
                    strHeader += "<div class='col-md-2 col-sm-6 col-xs-6'>";
                    strHeader += "<div class='header-logo'>";
                    strHeader += "<a href='modernshop.aspx'><img src='img/logo.png' alt='main logo'></a>";
                    strHeader += "</div>";
                    strHeader += "</div>";
                    //   header-search & total-cart 
                    strHeader += "<div class='col-md-2 col-sm-6 col-xs-6 float-right'>";
                    strHeader += "<div class='header-option-btns float-right'>";
                    //    header Account 
                    strHeader += "<div class='header-account float-left'>";
                    strHeader += "<ul>";
                    strHeader += "<li><a href='#' data-toggle='dropdown'><i class='pe-7s-config'></i></a>";
                    strHeader += "<ul class='dropdown-menu'>";
                    strHeader += "<li ><a href='#'> My Profile</a></li>";
                    strHeader += "<li ><a href='myinvoices.aspx'>My Invoices</a></li>";
                    strHeader += "<li ><a href='logOutLoad.aspx'> Log out</a></li>";
                    strHeader += "<li ><a href='#'> Deregister</a></li>";
                    strHeader += "</ul>";
                    strHeader += "</li>";
                    strHeader += "</ul>";
                    strHeader += "</div>";
                    //     Header Cart 
                    strHeader += "<div class='header-cart float-left'>";
                    //     Cart Toggle
                    strHeader += "<a class='cart-toggle' href='#' data-toggle='dropdown'>";
                    strHeader += "<i class='pe-7s-cart'></i>";
                    strHeader += "<span>" + items + "</span>";
                    strHeader += "</a>";
                    //      Mini Cart Brief
                    strHeader += "<div class='mini-cart-brief dropdown-menu text-left'>";
                    strHeader += "<div class='cart-items'><p>You have  <span>" + items + " items</span> in your shopping bag</p></div>";
                    //      Cart Total
                    strHeader += "<div class='cart-totals'>";
                    strHeader += "<h5>Total <span>R " + Math.Round(Convert.ToDouble(totalMoney), 2) + "</pan></h5>";
                    strHeader += "</div>";
                    //       Cart Button 
                    strHeader += "<div class='cart-bottom  clearfix'>";
                    strHeader += "<a href='moderncart.aspx'>View Items</a>";
                    strHeader += "<a href='moderncart.aspx'> Check Out</a>";
                    strHeader += "</div>";
                    strHeader += "</div>";
                    strHeader += "</div>";
                    strHeader += "</div>";
                    strHeader += "</div>";
                    //        primary-menu
                    strHeader += "<div class='col-md-8 col-xs-12'>";
                    strHeader += "<nav class='main-menu text-center'>";
                    strHeader += "<ul>";
                    strHeader += "<li class='ctive'><a href='modernshop.aspx'> Home </a>";
                    strHeader += "</li>";
                    strHeader += "<li><a href='changeStyle.aspx?Style=Modern'> Modern </a>";
                    strHeader += "</li>";
                    strHeader += "<li><a href='changeStyle.aspx?Style=Vintage'> Vintage</a>";
                    strHeader += "</li>";
                    strHeader += "</ul>";
                    strHeader += "</nav>";
                    strHeader += "<div class='mobile-menu'></div>";
                    strHeader += "</div>";

                    headerHtml.InnerHtml = strHeader;
                    // end header html
                }
                else if (Session["Vintage"] != null)
                {
                    // Start header html
                    string strHeader = "";

                    int userId = sr.getUserID(Convert.ToString(Session["Email"]));
                    int items = 0;
                    Session["UserID"] = userId;
                    int totalMoney = 0;
                    int countMoney = 0;
                    int count = 0;
                    countMoney = 0;
                    dynamic cartF = sr.listCart(userId);

                    foreach (cartTable c in cartF)
                    {
                        string display = "";
                        dynamic furnt = sr.listCartFuniture(Convert.ToInt16(c.FurnitureID));
                        foreach (FurnitureTable f in furnt)
                        {
                            countMoney += Convert.ToInt16(f.Price);
                        }
                        count += Convert.ToInt16(c.FurnitureNumber);

                    }
                    totalMoney += countMoney;
                    items = count;

                    // logo
                    strHeader += "<div class='col-md-2 col-sm-6 col-xs-6'>";
                    strHeader += "<div class='header-logo'>";
                    strHeader += "<a href='modernshop.aspx'><img src='img/logo.png' alt='main logo'></a>";
                    strHeader += "</div>";
                    strHeader += "</div>";
                    //   header-search & total-cart 
                    strHeader += "<div class='col-md-2 col-sm-6 col-xs-6 float-right'>";
                    strHeader += "<div class='header-option-btns float-right'>";
                    //    header Account 
                    strHeader += "<div class='header-account float-left'>";
                    strHeader += "<ul>";
                    strHeader += "<li><a href='#' data-toggle='dropdown'><i class='pe-7s-config'></i></a>";
                    strHeader += "<ul class='dropdown-menu'>";
                    strHeader += "<li ><a href=''> My Profile</a></li>";
                    strHeader += "<li ><a href='myinvoices.aspx'>My Invoices</a></li>";
                    strHeader += "<li ><a href='logOutLoad.aspx'> Log out</a></li>";
                    strHeader += "<li ><a href='#'> Deregister</a></li>";
                    strHeader += "</ul>";
                    strHeader += "</li>";
                    strHeader += "</ul>";
                    strHeader += "</div>";
                    //     Header Cart 
                    strHeader += "<div class='header-cart float-left'>";
                    //     Cart Toggle
                    strHeader += "<a class='cart-toggle' href='#' data-toggle='dropdown'>";
                    strHeader += "<i class='pe-7s-cart'></i>";
                    strHeader += "<span>" + items + "</span>";
                    strHeader += "</a>";
                    //      Mini Cart Brief
                    strHeader += "<div class='mini-cart-brief dropdown-menu text-left'>";
                    strHeader += "<div class='cart-items'><p>You have  <span>" + items + " items</span> in your shopping bag</p></div>";
                    //      Cart Total
                    strHeader += "<div class='cart-totals'>";
                    strHeader += "<h5>Total <span>R " + Math.Round(Convert.ToDouble(totalMoney), 2) + "</pan></h5>";
                    strHeader += "</div>";
                    //       Cart Button 
                    strHeader += "<div class='cart-bottom  clearfix'>";
                    strHeader += "<a href='moderncart.aspx'>View Items</a>";
                    strHeader += "<a href='moderncart.aspx'> Check Out</a>";
                    strHeader += "</div>";
                    strHeader += "</div>";
                    strHeader += "</div>";
                    strHeader += "</div>";
                    strHeader += "</div>";
                    //        primary-menu
                    strHeader += "<div class='col-md-8 col-xs-12'>";
                    strHeader += "<nav class='main-menu text-center'>";
                    strHeader += "<ul>";
                    strHeader += "<li class='ctive'><a href='modernshop.aspx'> Home </a>";
                    strHeader += "</li>";
                    strHeader += "<li><a href='changeStyle.aspx?Style=Modern'> Modern </a>";
                    strHeader += "</li>";
                    strHeader += "<li><a href='changeStyle.aspx?Style=Smart'>Smart</a>";
                    strHeader += "</li>";
                    strHeader += "</ul>";
                    strHeader += "</nav>";
                    strHeader += "<div class='mobile-menu'></div>";
                    strHeader += "</div>";

                    headerHtml.InnerHtml = strHeader;
                    // end header html
                }
            }
        }
    }
}