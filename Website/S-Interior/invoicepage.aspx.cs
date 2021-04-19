using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using S_Interior.FinalService; 

namespace S_Interior
{
    public partial class invoicepage : System.Web.UI.Page
    {
        FunctionsClient sr = new FunctionsClient();
        protected void Page_Load(object sender, EventArgs e)
        {
           // if (Session["checkOut"] != null )
            {
                
                if ( Session["Email"] !=null && Session["Login"] != null)
                {
                    if (Session["View"] != null && Session["checkout"] == null  && Session["Number"] == null)
                    {
                        Session["View"] = null;
                        string display = "";
                        string displayTotal = "";
                        string smallCarts = "";
                        string refDisp = "";
                        int num = 0;
                        int invoiceId = 0;
                        int id = sr.getUserID(Convert.ToString(Session["Email"]));
                        

                        dynamic invoice = sr.listAllInvoice("",id);
                        refDisp += "<h3>S-Interior </h3>";
                        refDisp += "<hr/>";
                        refDisp += "<h4>Choose Invoice to Read (sorted by date)</h4>";
                        refDisp += "<hr/>";
                        foreach (InvoiceTable i in invoice)
                        {
                            refDisp += "<h5>Date " + i.Date + "</h5>";
                            refDisp += "<h3><a href='chooseInvoice.aspx?Number="+i.Reference+"'>#" + i.Reference +"</a></h3>";
                            invoiceId = Convert.ToInt16(i.Reference);
                        }
                        displayTotal += "</tr>";
                        displayTotal += "<th></th>";
                        displayTotal += "<td>159 Juta Street , Braamfontain Johannesburg ,Gauteng / South Africa, 2001. Call 0767645130";
                        displayTotal += "</td>";
                        displayTotal += "</tr>";
                        Totalmytml.InnerHtml = displayTotal;
                        oderDis.InnerHtml = refDisp;

                       
                    }
                    else if (Session["checkOut"] !=null)
                    {
                        string display = "";
                        string displayTotal = "";
                        string smallCarts = "";
                        string refDisp = "";
                        int num = 0;
                        double total = 0;
                        int invoiceId = 0;
                        int id = sr.getUserID(Convert.ToString(Session["Email"]));
                        string refnum = Convert.ToString(Session["RefNumber"]);

                        dynamic invoice = sr.listAllInvoice(refnum,0);
                        foreach (InvoiceTable i in invoice)
                        {
                            displayTotal += "<tr>";
                            displayTotal += "<th>Subtotal</th>";
                            displayTotal += "<td>R" + i.CartTotal + "</td>";
                            displayTotal += "</tr>";
                            displayTotal += "<tr>";
                            displayTotal += "<tr>";
                            displayTotal += "<th>Discount</th>";
                            displayTotal += "<td>R" + i.Discount + "</td>";
                            displayTotal += "</tr>";
                            displayTotal += "<tr>";
                            displayTotal += "<th>Tax(15%)</th>";
                            displayTotal += "<td>R" + i.Tax + "</td>";
                            displayTotal += "</tr>";
                            displayTotal += "<tr>";
                            displayTotal += "<th>Order Total</th>";
                            displayTotal += "<td><strong>R" + i.TotalPrice + "</strong>";
                            displayTotal += "</td>";
                            displayTotal += "</tr>";
                            displayTotal += "<th></th>";
                            displayTotal += "<td>159 Juta Street , Braamfontain Johannesburg ,Gauteng / South Africa, 2001. Call 0767645130";
                            displayTotal += "</td>";
                            displayTotal += "</tr>";
                            refDisp += "<h3>S-Interior </h3>";
                            refDisp += "<h5> #" + i.Reference + "</h5>";
                            refDisp += "<h4>Date " + i.Date + "</h4>";
                            refDisp += "<hr/>";
                            invoiceId = Convert.ToInt16(i.Reference);
                        }
                        Totalmytml.InnerHtml = displayTotal;
                        oderDis.InnerHtml = refDisp;

                        dynamic itmes = sr.listIvoiceItems(invoiceId);
                        foreach (InvoiceItme cr in itmes)
                        {
                            num = Convert.ToInt16(cr.Quant);
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
                            }
                        }
                        display += smallCarts;

                        smallCartHtml.InnerHtml = display;
                        Session["crtTotal"] = null;
                        Session["checkout"] = null;
                    }else if (Session["Number"] != null)
                    {
                       
                        string display = "";
                        string displayTotal = "";
                        string smallCarts = "";
                        string refDisp = "";
                        int num = 0;
                        double total = 0;
                        int invoiceId = 0;
                        int id = sr.getUserID(Convert.ToString(Session["Email"]));
                        string refnum = Convert.ToString(Session["Number"]);
                        
                        dynamic invoice = sr.listAllInvoice(refnum, 0);
                        foreach (InvoiceTable i in invoice)
                        {
                            displayTotal += "<tr>";
                            displayTotal += "<th>Subtotal</th>";
                            displayTotal += "<td>R" + i.CartTotal + "</td>";
                            displayTotal += "</tr>";
                            displayTotal += "<tr>";
                            displayTotal += "<tr>";
                            displayTotal += "<th>Discount</th>";
                            displayTotal += "<td>R" + i.Discount + "</td>";
                            displayTotal += "</tr>";
                            displayTotal += "<tr>";
                            displayTotal += "<th>Tax(15%)</th>";
                            displayTotal += "<td>R" + i.Tax + "</td>";
                            displayTotal += "</tr>";
                            displayTotal += "<tr>";
                            displayTotal += "<th>Order Total</th>";
                            displayTotal += "<td><strong>R" + i.TotalPrice + "</strong>";
                            displayTotal += "</td>";
                            displayTotal += "</tr>";
                            displayTotal += "<th></th>";
                            displayTotal += "<td>159 Juta Street , Braamfontain Johannesburg ,Gauteng / South Africa, 2001. Call 0767645130";
                            displayTotal += "</td>";
                            displayTotal += "</tr>";
                            refDisp += "<h3>S-Interior </h3>";
                            refDisp += "<h5> #" + i.Reference + "</h5>";
                            refDisp += "<h4>Date " + i.Date + "</h4>";
                            refDisp += "<hr/>";
                            invoiceId = Convert.ToInt16(i.Reference);
                        }
                        Totalmytml.InnerHtml = displayTotal;
                        oderDis.InnerHtml = refDisp;

                        dynamic itmes = sr.listIvoiceItems(invoiceId);
                        foreach (InvoiceItme cr in itmes)
                        {
                            num = Convert.ToInt16(cr.Quant);
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
                            }
                        }
                        display += smallCarts;
                        Session["Number"] = null;
                        smallCartHtml.InnerHtml = display;
                    }
                }
                else
                {
                                
                }
                Session["checkOut"] = null;
            }
          //  else
            {

            }
        }
    }
}