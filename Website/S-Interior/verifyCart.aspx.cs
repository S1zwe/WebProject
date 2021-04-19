using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using S_Interior.FinalService;
namespace S_Interior
{
    public partial class verifyCart : System.Web.UI.Page
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
                dynamic cart = sr.listCart(id);
                if (cart != null)
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
                                Response.Redirect("moderncart.aspx");

                            }
                        }
                    }
                    if (cartCapacity.Capacity == furID.Capacity)
                    {
                        Session["RefNumber"] = null;
                        int refnum=  sr.GenerateReference(id);
                        Session["RefNumber"] = refnum;
                        foreach (cartTable c in cart)

                        {
                            dynamic fur = sr.getAboutFurniture(Convert.ToInt16(c.FurnitureID));

                            foreach (FurnitureTable f in fur)
                            {

                                int furniId = Convert.ToInt16(c.FurnitureID);
                                int qua = Convert.ToInt16(c.FurnitureNumber);

                                clsOders newodr = new clsOders
                                {
                                    id = id,
                                    furID = furniId,
                                    quant = qua,
                                    refNum = refnum ,
                                };
                                int mone = Convert.ToInt16((f.Price * c.FurnitureNumber));
                                bool add = sr.addOder(newodr);
                            }
                        }
                        bool mom = sr.editUserMoney(id, Convert.ToInt16(Session["TotalCart"]));
                        double num = (Convert.ToInt16(Session["TotalCart"]) * (0.01));
                        Session["TotalCart"] = null;
                        bool point = sr.editUserPoint(id, Convert.ToInt32(num));
                        Session["Verify"] = true;
                        Response.Redirect("moderncheckout.aspx");
                    }
                    else
                    {
                        Response.Redirect("moderncart.aspx");
                    }
                }

            }
            else
            {
                int id = Convert.ToInt16(Session["tempUser"]);
                dynamic cart = sr.listTempCart(id);
                if (cart != null)
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
                                Response.Redirect("moderncart.aspx");

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

                                int furniId = Convert.ToInt16(c.furID);
                                int qua = Convert.ToInt16(c.Quantity);

                                clsOders newodr = new clsOders
                                {
                                    id = id,
                                    furID = furniId,
                                    quant = qua
                                };
                                bool add = sr.addTempOder(newodr);
                               
                            }
                        }

                        Session["Verify"] = true;
                        Response.Redirect("moderncheckout.aspx");
                    }
                }
                else
                {
                    Response.Redirect("moderncart.aspx");
                }

            }
        }
    }
}