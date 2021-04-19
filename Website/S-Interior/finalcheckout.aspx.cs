using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using S_Interior.FinalService;
namespace S_Interior
{
    public partial class finalcheckout : System.Web.UI.Page
    {
        FunctionsClient sr = new FunctionsClient();
        List<int> furID = new List<int>();
        List<int> cartCapacity = new List<int>();

        protected void Page_Load(object sender, EventArgs e)
        {
            bool process = false;
            if (Session["Email"] != null && Session["Login"] != null)
            {
                int id = sr.getUserID(Convert.ToString(Session["Email"]));
                int Refnumber = Convert.ToUInt16(Session["RefNumber"]);
                dynamic cart = sr.listCart(id);
                if( cart != null)
                {
                    foreach (cartTable c in cart)
                    {
                        cartCapacity.Add(Convert.ToInt16(c.FurnitureID));
                        dynamic fur = sr.getAboutFurniture(Convert.ToInt16(c.FurnitureID));

                        foreach (FurnitureTable f in fur)
                        {
                            if (f.Quantity >= c.FurnitureNumber)
                            {
                                furID.Add(Convert.ToInt16(c.FurnitureID));
                            }
                            else
                            {
                                Response.Redirect("moderncheckout.aspx");

                            }
                        }
                    }
                    if (cartCapacity.Capacity == furID.Capacity)
                    {
                        classInvoice neInvoice = new classInvoice
                        {
                            urID = id,
                            refNum = Refnumber,
                            totalprice = Convert.ToInt16(Session["PaymentDue"]),
                            tax = Convert.ToInt16(Session["Tax"]),
                            carttotal = Convert.ToInt16(Session["crtTotal"]),
                            discount = Convert.ToInt16(Session["Discount"]),
                        };
                        bool ok = sr.addnewInvoice(neInvoice);
                        if( ok ==true)
                        {
                            foreach (cartTable c in cart)

                            {
                                clsOders invItems = new clsOders
                                {
                                    refNum = Refnumber ,
                                    furID =Convert.ToInt16(c.FurnitureID ),
                                    quant =Convert.ToInt16(c.FurnitureNumber)
                                };
                                bool inOk = sr.addnewInvoiceItems(invItems);

                                if(inOk ==true)
                                {
                                    dynamic fur = sr.getAboutFurniture(Convert.ToInt16(c.FurnitureID));
                                    foreach (FurnitureTable f in fur)
                                    {

                                        int furniId = Convert.ToInt16(c.FurnitureID);
                                        int qua = Convert.ToInt16(c.FurnitureNumber);
                                        {

                                            bool delete = sr.deleteFurniture(Convert.ToInt16(c.FurnitureID), Convert.ToInt16(c.FurnitureNumber));
                                            bool del = sr.deleteCartFurniture(id, Convert.ToInt16(c.FurnitureID));
                                            if (Session["Paid"] !=null )
                                            {
                                                sr.editRegOder(id, Refnumber);
                                            };
                                           
                                        }
                                    }
                                }
                                else
                                {
                                    Response.Redirect("modernshop.aspx");
                                }  
                            }
                            bool mom = sr.editUserMoney(id, Convert.ToInt16(Session["TotalCart"]));
                            double num = (Convert.ToInt16(Session["TotalCart"]) * (0.01));
                            Session["TotalCart"] = null;
                            if (Session["Apply"] != null)
                            {
                                bool del = sr.DeleleUserPoint(id);
                                Session["Apply"] = null;
                            }
                            bool point = sr.editUserPoint(id, Convert.ToInt32(num));
                            Session["checkOut"] = true;
                            Response.Redirect("invoicepage.aspx");
                        }
                        else
                        {
                            Response.Redirect("modernshop.aspx");
                        }

                           
                       
                    }else
                    {
                        Response.Redirect("moderncheckout.aspx");
                    }
                }
                
            }
            else
            {
                int id = Convert.ToInt16(Session["tempUser"]);
                dynamic cart = sr.listTempCart(id);
                if( cart != null)
                {
                    foreach (SessionCart c in cart)
                    {
                        cartCapacity.Add(Convert.ToInt16(c.furID));
                        dynamic fur = sr.getAboutFurniture(Convert.ToInt16(c.furID));

                        foreach (FurnitureTable f in fur)
                        {
                            if (f.Quantity >= c.Quantity)
                            {
                                furID.Add(Convert.ToInt16(c.furID));
                            }
                            else
                            {
                                Response.Redirect("moderncheckout.aspx");

                            }
                        }
                    }
                    if (cartCapacity.Capacity == furID.Capacity)
                    {
                        foreach (SessionCart c in cart)

                        {
                            dynamic fur = sr.getAboutFurniture(Convert.ToInt16(c.furID));

                            foreach (FurnitureTable f in fur)
                            {
                                {
                                    bool delete = sr.deleteFurniture(Convert.ToInt16(c.furID), Convert.ToInt16(c.Quantity));
                                    bool del = sr.deleteTempCartFurniture(id, Convert.ToInt16(c.furID));
                                }
                            }
                        }

                        Response.Redirect("modernshop.aspx");
                    }
                }else
                {
                    Response.Redirect("moderncheckout.aspx");
                }
            

            }

                 
        }
    }
}