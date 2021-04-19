using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using S_Interior.FinalService;

namespace S_Interior
{
    public partial class registernew : System.Web.UI.Page
    {
        FunctionsClient sr = new FunctionsClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            string existingEmail = Email.Value;
            bool existingUser = sr.checkUser(existingEmail);
            if(existingUser == true)
            {
                Response.Redirect("login.aspx");
            }
            else
            {
                if (pass.Value.Equals(cPass.Value))
                {
                    // int IsREg = cc.RegisteredUser(username.Value, pass.Value);
                    if (cPass.Value != "" && Name.Name != "" && Surname.Value != "" && Adress.Value != "" && Email.Value != "")
                    {
                        if (cPass.Value == pass.Value)
                        {
                            classUser newUser = new classUser
                            {
                                name = Name.Value,
                                surname = Surname.Value,
                                address = Adress.Value,
                                farvorite = choice.Value,
                                password = pass.Value,
                                email = Email.Value
                            };
                            bool registered = sr.userRegister(newUser);
                            if (registered == true)
                            {
                                string loged = sr.loginUser(Email.Value, pass.Value);
                                if (loged == "modern")
                                {
                                   
                                    Session["Modern"] = true;
                                    Session["Login"] = true;
                                    Session["Smart"] = false;
                                    Session["Vintage"] = false;
                                    Session["Email"] = Email.Value;
                                    Response.Redirect("modernshop.aspx");
                                }else if( loged == "vintage")
                                {
                                    Session["Modern"] = false;
                                    Session["Login"] = true;
                                    Session["Smart"] = false;
                                    Session["Vintage"] = true;
                                    Session["Email"] = Email.Value;
                                    Response.Redirect("modernshop.aspx");
                                }
                                else
                                {
                                    Session["Modern"] = false;
                                    Session["Login"] = true;
                                    Session["Smart"] = true;
                                    Session["Vintage"] = true;
                                    Session["Email"] = Email.Value;
                                    Response.Redirect("modernshop.aspx");
                                }
                            }
                            else
                            {
                                Response.Redirect("register.aspx");
                            }
                        }
                    }
                    else
                    {
                        Response.Redirect("register.aspx");
                    }
                }
            }
          
        }
    }
}