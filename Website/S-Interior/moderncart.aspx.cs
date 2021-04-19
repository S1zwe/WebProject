using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using S_Interior.FinalService;

namespace S_Interior
{
    public partial class moderncart : System.Web.UI.Page
    {
        FunctionsClient sr = new FunctionsClient();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["Email"] != null && Session["Login"] != null)
            {
                Session["cartT"] = true;
                Session["DeleteCart"] = true;
                string display = "";
                display += "<thead>";
                display += "<tr>";
                display += "<th class='pro-thumbnail'>Image</th>";
                display += "<th class='pro-title'>Product</th>";
                display += "<th class='pro-price'>Price</th>";
                display += "<th class='pro-quantity'>Quantity</th>";
                display += "<th class='pro-subtotal'>Total</th>";
                display += "<th class='pro-Update'>Update</th>";
                display += "<th class='pro-Left'>Only Left</th>";
                display += "</tr>";
                display += "</thead>";
                myHtml.InnerHtml = display;


                dynamic cartF = sr.listCart(Convert.ToInt16(Session["UserID"]));
                String finalprod = "";
                string path = "img/product/";
                string extension = ".jpg";
                int num = 0;
                double total = 0;
                
                double tot = 0;
                double finalTotal;
                foreach (cartTable c in cartF)
                {
                    String prodDisplay = "";
                    dynamic furnt = sr.listCartFuniture(Convert.ToInt16(c.FurnitureID));
                    num = Convert.ToInt16(c.FurnitureNumber);
                    foreach (FurnitureTable f in furnt)
                    {
                        prodDisplay += "<tr>";
                        prodDisplay += "<td class='pro-thumbnail'><a href='#'><img src='" + path + f.Image + extension + "' alt=''/></a></td>";
                        prodDisplay += "<td class='pro-title'><a href='#'>" + f.Name + "</a></td>";
                        prodDisplay += "<td class='pro-price'><span class='amount'>R" + Math.Round(f.Price) + "</span></td>";
                        prodDisplay += "<td class='pro-quantity'><a href='moderneditcart.aspx?ID=" + f.furnitureID+"'><div class='product-quantity'><input type='text' value='" + num + "' /></div></a></td>";
                        prodDisplay += "<td class='pro-subtotal'>R" + Math.Round(f.Price * num, 2) + "</td>";
                        prodDisplay += "<td class='pro-remove'><a href='deleteCart.aspx?FurID=" + f.furnitureID + "' >×</a></td>";
                        prodDisplay += "<td class='pro-Left'><span class='amount'>"+f.Quantity+"</span></a></td>";
                        prodDisplay += "</tr>";
                        total += Convert.ToInt16(f.Price * num);
                    }
                    finalprod += prodDisplay;
                }
                cartHtml.InnerHtml = finalprod;

                double discount;
                double per = (0.05);
              if( total >= 500)
                {
                    discount = total * per;
                }
                else
                {
                    discount = 0;
                }
                
                tot =total - discount;
                Session["Discount"] = discount;
               Session["TotalPayment"] = tot;
                if (Session["checkOut"] == null)
                {
                    if (Session["Apply"] != null)
                    {
                        finalTotal = tot - Convert.ToDouble(Session["Coupontotal"]);
                        Session["CouponTotal"]=null;
                        Session["Apply"] = true;
                    }
                    else
                    {
                        finalTotal = tot;
                    }
                }
                else
                {
                    finalTotal = 0;
                    Session["checkOut"] = null;
                }
                
                Session["TotalCart"] = total;
                Session["PaymentDue"] = Math.Round(finalTotal + (finalTotal * (15.00 / 100)), 2);
                Session["Tax"] = Math.Round(finalTotal * (15.00 / 100), 2);
                // Displaying total item price in the Cart
                string totaDisplay = "";
                totaDisplay += "<tbody>";
                totaDisplay += "<tr class='cart-subtotal'>";
                totaDisplay += "<th> Subtotal</th>";
                totaDisplay += "<td><span class='amount'>R" + Math.Round(total, 2) + "</span></td>";
                totaDisplay += "</tr>";
                totaDisplay += "<tr class='cart-subtotal'>";
                totaDisplay += "<th>VAT(15%) Total</th>";
                totaDisplay += "<td><span class='amount'>R" + Math.Round(finalTotal * (15.00 / 100), 2) + "</span></td>";
                totaDisplay += "</tr>";
                totaDisplay += "<tr class='cart-subtotal'>";
                totaDisplay += "<th>5% of over R500</th>";
                totaDisplay += "<td><span class='amount'>R" + Math.Round(discount, 2) + "</span></td>";
                totaDisplay += "</tr>";
                totaDisplay += "<tr class='order-total'>";
                totaDisplay += "<th> Total </th>";
                totaDisplay += "<td>";
                totaDisplay += "<strong><span class='amount'>R" + Math.Round(finalTotal + (finalTotal * (15.00 / 100)), 2) + "</span></strong>";
                totaDisplay += "</td>";
                totaDisplay += "</tr>";
                totaDisplay += "</tbody>";
                Session["cartTotal"] = total;
                Session["PaymentDue"] = Math.Round(finalTotal + (finalTotal * (15.00 / 100)), 2);
                cartTotalHtml.InnerHtml = totaDisplay;
               
            }
            else
            {
                if(Session["tempUser"] != null)
                {
                    Session["cartT"] = true;
                    Session["DeleteCart"] = true;
                    string display = "";
                    display += "<thead>";
                    display += "<tr>";
                    display += "<th class='pro-thumbnail'>Image</th>";
                    display += "<th class='pro-title'>Product</th>";
                    display += "<th class='pro-price'>Price</th>";
                    display += "<th class='pro-quantity'>Quantity</th>";
                    display += "<th class='pro-subtotal'>Total</th>";
                    display += "<th class='pro-Update'>Update</th>";
                    display += "<th class='pro-Left'>Only Left</th>";
                    display += "</tr>";
                    display += "</thead>";
                    myHtml.InnerHtml = display;

                    dynamic cartF = sr.listTempCart(Convert.ToInt16(Session["tempUser"]));
                    String finalprod = "";
                    string path = "img/product/";
                    string extension = ".jpg";
                    int num = 0;
                    double total = 0;
                    foreach (SessionCart c in cartF)
                    {
                        String prodDisplay = "";
                        dynamic furnt = sr.listCartFuniture(Convert.ToInt16(c.furID));
                        num = Convert.ToInt16(c.Quantity);
                        foreach (FurnitureTable f in furnt)
                        {
                            prodDisplay += "<tr>";
                            prodDisplay += "<td class='pro-thumbnail'><a href='#'><img src='" + path + f.Image + extension + "' alt=''/></a></td>";
                            prodDisplay += "<td class='pro-title'><a href='#'>" + f.Name + "</a></td>";
                            prodDisplay += "<td class='pro-price'><span class='amount'>R" + Math.Round(f.Price) + "</span></td>";
                            prodDisplay += "<td class='pro-quantity'><a href='moderneditcart.aspx?ID=" + f.furnitureID + "'><div class='product-quantity'><input type='text' value='" + num + "' /></div></a></td>";
                            prodDisplay += "<td class='pro-subtotal'>R" + Math.Round(f.Price * num, 2) + "</td>";
                            prodDisplay += "<td class='pro-remove'><a href='deleteCart.aspx?FurID=" + f.furnitureID + "' >×</a></td>";
                            prodDisplay += "<td class='pro-Left'><span class='amount'>" + f.Quantity + "</span></a></td>";
                            prodDisplay += "</tr>";
                            total += Convert.ToInt16(f.Price * num);
                        }
                        finalprod += prodDisplay;
                    }
                    cartHtml.InnerHtml = finalprod;
                    // Displaying total item price in the Cart
                  //  Session["Tax"] = Math.Round(finalTotal * (15.00 / 100), 2);
                    string totaDisplay = "";
                    totaDisplay += "<tbody>";
                    totaDisplay += "<tr class='cart-subtotal'>";
                    totaDisplay += "<th>VAT(15%) Total</th>";
                    totaDisplay += "<td><span class='amount'>R" + Math.Round(total * (15.00 / 100), 2) + "</span></td>";
                    totaDisplay += "</tr>";
                    totaDisplay += "<tr class='cart-subtotal'>";
                    totaDisplay += "<th> Subtotal</th>";
                    totaDisplay += "<td><span class='amount'>R" + Math.Round(total, 2) + "</span></td>";
                    totaDisplay += "</tr>";
                    totaDisplay += "<tr class='order-total'>";
                    totaDisplay += "<th> Total </th>";
                    totaDisplay += "<td>";
                    totaDisplay += "<strong><span class='amount'>R" + Math.Round(total + (total * (15.00 / 100)), 2) + "</span></strong>";
                    totaDisplay += "</td>";
                    totaDisplay += "</tr>";
                    totaDisplay += "</tbody>";
                    Session["cartTotal"] = total;
                    Session["PaymentDue"] = Math.Round(total + (total * (15.00 / 100)), 2);

                    cartTotalHtml.InnerHtml = totaDisplay;
                }     
            }
            } 
    }
}