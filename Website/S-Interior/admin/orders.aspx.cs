using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using S_Interior.FinalService;
namespace S_Interior.admin
{
    public partial class soders : System.Web.UI.Page
    {
        FunctionsClient sr = new FunctionsClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            if ( Session["Pending"] == null && Session["Shipping"]==null && (Session["All"]== null || Session["All"] !=null))
            {
                dynamic oder = sr.listAllOders("");
                string listDisp = "";
                foreach (Oder d in oder)
                {
                    string status = d.Status;
                    string warn = "";
                    if (status == "Pending")
                    {
                        warn = "<td><span class='badge badge-danger'>Pending</span></td>";
                    }
                    else if (status == "Shipped")
                    {
                        warn = "<td><span class='badge badge-warning text-white'>Shipped</span></td>";
                    }
                    else
                    {
                        warn = "<td><span class='badge badge-warning text-white'>Paid</span></td>";
                    }
                    dynamic usr = sr.getAbautUsers(Convert.ToInt16(d.UserID));
                    dynamic fur = sr.getAboutFurniture(Convert.ToInt16(d.FurID));
                    foreach (FurnitureTable f in fur)
                    {
                        foreach (UserTable u in usr)
                        {
                            listDisp += "<tr>";
                            listDisp += "<td>#0001</td>";
                            listDisp += "<td>" + d.Dates + "</td>";
                            listDisp += "<td>" + u.Surname + "</td>";
                            listDisp += "<td>" + u.Name + "</td>";
                            listDisp += "<td>" + u.Email + "</td>";
                            listDisp += "<td>" + d.ReferenceNumber + "</td>";
                            listDisp += "<td>" + d.Quantity + "</td>";
                            listDisp += warn;
                            listDisp += "</tr>";
                        }
                    }
                }
                OrList.InnerHtml = listDisp;
            }else if (Session["Pending"] != null)
            {
                dynamic oder = sr.listAllOders("Pending");
                string listDisp = "";
                foreach (Oder d in oder)
                {
                    string status = d.Status;
                    string warn = "";
                    if (status == "Pending")
                    {
                        warn = "<td><span class='badge badge-danger'>Pending</span></td>";
                    }
                    else if (status == "Shipped")
                    {
                        warn = "<td><span class='badge badge-warning text-white'>Shipped</span></td>";
                    }
                    else
                    {
                        warn = "<td><span class='badge badge-warning text-white'>Paid</span></td>";
                    }
                    dynamic usr = sr.getAbautUsers(Convert.ToInt16(d.UserID));
                    dynamic fur = sr.getAboutFurniture(Convert.ToInt16(d.FurID));
                    foreach (FurnitureTable f in fur)
                    {
                        foreach (UserTable u in usr)
                        {
                            listDisp += "<tr>";
                            listDisp += "<td>#0001</td>";
                            listDisp += "<td>" + d.Dates + "</td>";
                            listDisp += "<td>" + u.Surname + "</td>";
                            listDisp += "<td>" + u.Name + "</td>";
                            listDisp += "<td>" + u.Email + "</td>";
                            listDisp += "<td>" + d.ReferenceNumber + "</td>";
                            listDisp += "<td>" + d.Quantity + "</td>";
                            listDisp += warn;
                            listDisp += "</tr>";
                        }
                    }
                }
                OrList.InnerHtml = listDisp;
            }
            else 
            {
                dynamic oder = sr.listAllOders("Paid");
                string listDisp = "";
                foreach (Oder d in oder)
                {
                    string status = d.Status;
                    string warn = "";
                    if (status == "Pending")
                    {
                        warn = "<td><span class='badge badge-danger'>Pending</span></td>";
                    }
                    else if (status == "Shipped")
                    {
                        warn = "<td><span class='badge badge-warning text-white'>Shipped</span></td>";
                    }
                    else
                    {
                        warn = "<td><span class='badge badge-warning text-white'>Paid</span></td>";
                    }
                    dynamic usr = sr.getAbautUsers(Convert.ToInt16(d.UserID));
                    dynamic fur = sr.getAboutFurniture(Convert.ToInt16(d.FurID));
                    foreach (FurnitureTable f in fur)
                    {
                        foreach (UserTable u in usr)
                        {
                            listDisp += "<tr>";
                            listDisp += "<td>#0001</td>";
                            listDisp += "<td>" + d.Dates + "</td>";
                            listDisp += "<td>" + u.Surname + "</td>";
                            listDisp += "<td>" + u.Name + "</td>";
                            listDisp += "<td>" + u.Email + "</td>";
                            listDisp += "<td>" + d.ReferenceNumber + "</td>";
                            listDisp += "<td>" + d.Quantity + "</td>";
                            listDisp += warn;
                            listDisp += "</tr>";
                        }
                    }
                }
                OrList.InnerHtml = listDisp;
            }
            
        }
    }
}