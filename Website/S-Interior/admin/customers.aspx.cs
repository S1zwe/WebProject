using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using S_Interior.FinalService;
namespace S_Interior.admin
{
    public partial class scustomers : System.Web.UI.Page
    {
        FunctionsClient sr = new FunctionsClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            string display = "";
            dynamic cus = sr.getRecCustomers("");
                foreach ( UserTable c in cus)
                {
                    display += "<tr>";
                    display += "<td>#"+c.Id+"</td>";
                    display += "<td><a href='#'>"+c.Surname+"</a></td>";
                    display += "<td><a href='#'>" + c.Name + "</a></td>";
                    display += "<td><a href='#'>"+c.Email+"</a></td>";
                    display += "<td><a href='#'>" + Math.Round(Convert.ToDouble(c.Points), 2) + "</a></td>";
                    display += "<td>R"+Math.Round(Convert.ToDouble(c.TotalMoney),2)+"</td>";
                    display += "</tr>";
                }
    
            customersHtml.InnerHtml = display;

        }
    }
}