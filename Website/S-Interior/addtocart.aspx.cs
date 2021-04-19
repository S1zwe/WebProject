using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using S_Interior.FinalService; 

namespace S_Interior
{
    public partial class addtocart : System.Web.UI.Page
    {
        FunctionsClient sr = new FunctionsClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Cart"] != null)
            {
                if (Session["Login"] != null)
                {
                    
                    int usID = sr.getUserID(Convert.ToString(Session["Email"]));
                    int furniture = Convert.ToInt16(Request.QueryString["FurID"]);
                    if (furniture == 0)
                    {
                        Response.Redirect("aboutdesign.aspx?funID=" + Convert.ToInt16(Session["InteriorID"]));
                        if (Session["Shop"] != null)
                        {
                            Response.Redirect("aboutdesign.aspx?funID=" + Convert.ToInt16(Session["InteriorID"]));
                            Session["Cart"] = null;
                        }
                        else
                        {
                            Response.Redirect("modernShop.aspx");
                            Session["Cart"] = null;
                        }
                        
                    }
                    else
                    {
                        int cartInfor = sr.SearchCart(furniture, usID);
                        if (cartInfor == -1)
                        {
                            classCart crt = new classCart
                            {
                                userid = usID,
                                furnitureid = furniture,
                                quantiyt = 1,

                            };

                            bool added = sr.addToCart(crt);
                            if (added == true)
                            {
                                if (Session["Shop"] != null)
                                {
                                    Response.Redirect("aboutdesign.aspx?funID=" + Convert.ToInt16(Session["InteriorID"]));
                                    Session["Cart"] = null;

                                }
                                else
                                {
                                    
                                    Response.Redirect("modernShop.aspx");
                                    Session["Cart"] = null;
                                }
                               
                            }
                        }
                        else
                        {
                            sr.editCart(usID, furniture, cartInfor);
                            if (Session["Shop"] != null)
                            {
                                Response.Redirect("aboutdesign.aspx?funID=" + Convert.ToInt16(Session["InteriorID"]));
                                Session["Cart"] = null;
                            }
                            else
                            {
                                Response.Redirect("modernshop.aspx");
                                Session["Cart"] = null;
                            }
                            
                        }
                    }

                }
                else
                {
                    int usID = Convert.ToInt16(Session["tempUser"]);
                    int furniture = Convert.ToInt16(Request.QueryString["FurID"]);
                    if (furniture == 0)
                    {
                       
                        if (Session["Shop"] != null)
                        {
                            Response.Redirect("aboutdesign.aspx?funID=" + Convert.ToInt16(Session["InteriorID"]));
                            Session["Cart"] = null;
                        }
                        else
                        {
                            Response.Redirect("modernshop.aspx");
                            Session["Cart"] = null;
                        }
                        
                    }
                    else
                    {
                        int cartInfor = sr.SearchTempCart(furniture, usID);
                        if (cartInfor == -1)
                        {
                            classSession crt = new classSession
                            {
                                tempId = usID,
                                furId = furniture,
                                quant = 1,

                            };

                            bool added = sr.addTempcart(crt);
                            if (added == true)
                            {
                                
                                if (Session["Shop"] != null)
                                {
                                    Response.Redirect("aboutdesign.aspx?funID=" + Convert.ToInt16(Session["InteriorID"]));
                                    Session["Cart"] = null;
                                }
                                else
                                {
                                    Response.Redirect("modernshop.aspx");
                                    Session["Cart"] = null;
                                }
                            }
                            else
                            {
                                Response.Redirect("login.aspx");
                                Session["Cart"] = null;
                            }
                        }
                        else
                        {
                            sr.editTempCart(usID, furniture, cartInfor);
                            if (Session["Shop"] != null)
                            {
                                Response.Redirect("aboutdesign.aspx?funID=" + Convert.ToInt16(Session["InteriorID"]));
                                Session["Cart"] = null;
                            }
                            else
                            {
                                Response.Redirect("modernshop.aspx");
                                Session["Cart"] = null;
                            }
                           
                        }
                    }

                }
            }
            else
            {
                Response.Redirect("modernshop.aspx");
                Session["Cart"] = null;
            }
             
        }
    }
}