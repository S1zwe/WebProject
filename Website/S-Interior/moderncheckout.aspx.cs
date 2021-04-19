using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using S_Interior.FinalService;

namespace S_Interior
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private string dblTot = "";
        FunctionsClient sr = new FunctionsClient();
        protected void Page_Load(object sender, EventArgs e)
        {
              if (Session["cartT"] != null)
            {
                if (Session["Login"] == null && Session["Email"] == null && Session["UserID"] == null)
                {
                    int tempId = Convert.ToInt16(Session["tempUser"]);
                    string display = "";
                    string displayTotal = "";

                    dynamic cart = sr.listTempCart(tempId);
                    string smallCarts = "";
                    int num = 0;
                    double total = 0;

                    int totalInside = 0;

                    foreach (SessionCart cr in cart)
                    {
                        num = Convert.ToInt16(cr.Quantity);
                        dynamic furnt = sr.listCartFuniture(Convert.ToInt16(cr.furID));
                        foreach (FurnitureTable f in furnt)
                        {
                            smallCarts += "<tr>";
                            smallCarts += "<td class='product-name'>";
                            smallCarts += f.Name + "<strong class='product-qty'> ×" + num + "</strong>";
                            smallCarts += "</td>";
                            smallCarts += "<td class='product-total'>";
                            smallCarts += "<span class='amount'>R" + Math.Round(f.Price * num, 2) + "</span>";
                            smallCarts += "</td>";
                            smallCarts += "</tr>";
                            total += Convert.ToInt16(f.Price * num);
                        }
                    }

                    display += smallCarts;
                    double allTotal = Convert.ToDouble(Session["PaymentDue"]);
                    smallCartHtml.InnerHtml = display;
                    double tot = total * (15.00 / 100);
                    displayTotal += "<tr>";
                    displayTotal += "<th>Cart Subtotal</th>";
                    displayTotal += "<td>R" + Math.Round(total, 2) + "</td>";
                    displayTotal += "</tr>";
                    displayTotal += "<tr>";
                    displayTotal += "<th>Order Total</th>";
                    displayTotal += "<td><strong>R" + allTotal + "</strong>";
                    displayTotal += "</td>";
                    displayTotal += "</tr>";
                    Totalmytml.InnerHtml = displayTotal;
                    dblTot = Convert.ToString(Math.Round(allTotal * 0.067, 2)).Replace(",", ".");
                    string refDisp = "<h3>Your order</h3>";
                    oderDis.InnerHtml = refDisp;
                }
                else
                {

                    string display = "";
                    string displayTotal = "";
                    int id = Convert.ToInt16(Session["UserID"]);
                    dynamic cart = sr.listCart(id);
                    string smallCarts = "";
                    int num = 0;
                    double total = 0;
                   

                    int totalInside = 0;

                    foreach (cartTable cr in cart)
                    {
                        num = Convert.ToInt16(cr.FurnitureNumber);
                        dynamic furnt = sr.listCartFuniture(Convert.ToInt16(cr.FurnitureID));
                        foreach (FurnitureTable f in furnt)
                        {
                            smallCarts += "<tr>";
                            smallCarts += "<td class='product-name'>";
                            smallCarts += f.Name + "<strong class='product-qty'> ×" + num + "</strong>";
                            smallCarts += "</td>";
                            smallCarts += "<td class='product-total'>";
                            smallCarts += "<span class='amount'>R" + Math.Round(f.Price * num, 2) + "</span>";
                            smallCarts += "</td>";
                            smallCarts += "</tr>";
                            total += Convert.ToInt16(f.Price * num);
                        }
                    }

                    display += smallCarts;
                    double allTotal = Convert.ToDouble(Session["PaymentDue"]);
                    smallCartHtml.InnerHtml = display;
                    double tot = total * (15.00 / 100);
                    displayTotal += "<tr>";
                    displayTotal += "<th>Cart Subtotal</th>";
                    displayTotal += "<td>R" + Math.Round(total, 2) + "</td>";
                    displayTotal += "</tr>";
                    displayTotal += "<tr>";
                    displayTotal += "<th>Order Total</th>";
                    displayTotal += "<td><strong>R" + allTotal + "</strong>";
                    displayTotal += "</td>";
                    displayTotal += "</tr>";
                    Totalmytml.InnerHtml = displayTotal;
                    string refDisp = "";
                    refDisp += "<h3>Your order ID "+Session["RefNumber"] +"</h3>";
                    oderDis.InnerHtml = refDisp;
                    Session["crtTotal"] = total;
                    dblTot = Convert.ToString(Math.Round(allTotal * 0.067, 2)).Replace(",", ".");
                }
            }
            else
            {
               Response.Redirect("moderncart.aspx");
            }


            
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int orderNumber = rand.Next();
            Session["Paid"] = true;
            int num1 = 123;
            // string amount = Convert.ToString(Math.Round(Convert.ToDouble(Request.QueryString["PricItems"].ToString()), 2)).Replace(",", ".");
            //Remember we have to do this for all the items in the cart (i think)

            Response.Write("<form action='https://www.sandbox.paypal.com/cgi-bin/webscr' method='post' name='buyCredits' id='buyCredit'>");
            Response.Write("<input type='hidden' name='cmd' value='_xclick'>");
            Response.Write("<input type='hidden' name='business' value='Space@sinterior.co.za'>");//use business owmer's email here
            Response.Write("<input type='hidden' name='currency_code' value='USD'>");
            Response.Write("<input type='hidden' name='item_name' value='" + "Cart Payment" + "'>");
            Response.Write("<input type='hidden' name='item_number' value='" + 1 + " o'>"); //any item number
            Response.Write("<input type='hidden' name='amount' value='" + dblTot + "'>");
            Response.Write("<input type='hidden' name='return' value='http://localhost:65003/finalcheckout.aspx'>");
            Response.Write("</form>");

            Response.Write("<script type='text/javascript'>");
            Response.Write("document.getElementById('buyCredit').submit();");
            Response.Write("</script>");
        }
    } 
}