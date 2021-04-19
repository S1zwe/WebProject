using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using S_Interior.FinalService;
namespace S_Interior
{
    public partial class logedUserFirstLoad : System.Web.UI.Page
    {
        FunctionsClient sr = new FunctionsClient();
        List<int> tempCart = new List<int>();
        List<int> cartCapacity = new List<int>();
        List<int> unId = new List<int>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Remember"] != null)
            {
                dynamic cartF = sr.listTempCart(Convert.ToInt16(Session["Remember"]));
                int usID = sr.getUserID(Convert.ToString(Session["Email"]));
                if(cartF != null)
                {
                    foreach (SessionCart c in cartF)
                    {
                        tempCart.Add(Convert.ToInt16(c.furID));
                        dynamic userCart = sr.listCart(Convert.ToInt16(c.furID));
                        if (userCart != null)
                        {
                            foreach (cartTable uc in userCart)
                            {
                                cartCapacity.Add(Convert.ToInt16(uc.FurnitureID));
                            }
                        }
                        else
                        {
                            foreach (SessionCart uc in cartF)
                            {
                                unId.Add(Convert.ToInt16(uc.furID));
                            }
                        }

                    }

                   
                        foreach (SessionCart ses in cartF)
                        {
                            int furi = Convert.ToInt16(ses.furID);
                            int cartInfor = sr.SearchCart(furi, usID);
                            if (cartInfor == -1)
                            {
                                classCart crt = new classCart
                                {
                                    userid = usID,
                                    furnitureid = furi,
                                    quantiyt = Convert.ToInt16(ses.Quantity),
                                };
                                bool added = sr.addToCart(crt);
                            }
                            else
                            {
                                sr.editCart(usID, furi, cartInfor);
                            }
                        }
                    Response.Redirect("Modernshop.aspx");
                }
                else
                {
                    Response.Redirect("Modernshop.aspx");
                }
            }
            else
            {
                Response.Redirect("Modernshop.aspx");
            }
        }
    }
}