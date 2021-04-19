using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using S_Interior.FinalService;

namespace S_Interior.admin
{
    public partial class sadmin : System.Web.UI.Page
    {
        FunctionsClient sr = new FunctionsClient();
        protected void Page_Load(object sender, EventArgs e)
        {
           

                // For Total Registers users
                int countRegUsers = 0;
                dynamic users = sr.listRegisteredUsers("");
                foreach (UserTable u in users)
                {
                    countRegUsers += 1;
                }
                string suers = "";
                suers += "<div class='card'>";
                suers += "<div class='card-body'>";
                suers += "<div class='dash-widget-header'>";
                suers += "<span class='dash-widget-icon bg-primary'>";
                suers += "<i class='fe fe-users'></i>";
                suers += "</span>";
                suers += "</div>";
                suers += "<div class='dash-widget-info'>";
                suers += "<h3>"+countRegUsers+"</h3>";
                suers += "<h6 class='text-muted'>Total Active Users</h6>";
                suers += "<div class='progress progress-sm'>";
                suers += "<div class='progress-bar bg-primary w-50'></div>";
                suers += "</div>";
                suers += "</div>";
                suers += "</div>";
                suers += "</div>";
                userhm.InnerHtml = suers;

                // Users Registered per day
                int countRegPerDay = 0;
                string dats = DateTime.Now.Date.ToString();
                dynamic regdays = sr.listRegisteredUsers(dats); 
                foreach (UserTable u in regdays)
                {
                    countRegPerDay += 1;
                }
                string usersRegperDay = "";
                usersRegperDay += "<div class='card'>";
                usersRegperDay += "<div class='card-body'>";
                usersRegperDay += "<div class='dash-widget-header'>";
                usersRegperDay += "<span class='dash-widget-icon bg-primary'>";
                usersRegperDay += "<i class='fe fe-users'></i>";
                usersRegperDay += "</span>";
                usersRegperDay += "</div>";
                usersRegperDay += "<div class='dash-widget-info'>";
                usersRegperDay += "<h3>" + countRegPerDay + "</h3>";
                usersRegperDay += "<h6 class='text-muted'>New Users Today</h6>";
                usersRegperDay += "<div class='progress progress-sm'>";
                usersRegperDay += "<div class='progress-bar bg-primary w-50'></div>";
                usersRegperDay += "</div>";
                usersRegperDay += "</div>";
                usersRegperDay += "</div>";
                usersRegperDay += "</div>";
                userReg.InnerHtml = usersRegperDay;

                // Users per day 
                int countPerDay = 0;
                dynamic perday = sr.listRegisteredTempUsers();
                foreach (SessionUser u in perday)
                {
                    countPerDay += 1;
                }
                string usersperDay = "";
                usersperDay += "<div class='card'>";
                usersperDay += "<div class='card-body'>";
                usersperDay += "<div class='dash-widget-header'>";
                usersperDay += "<span class='dash-widget-icon bg-primary'>";
                usersperDay += "<i class='fe fe-users'></i>";
                usersperDay += "</span>";
                usersperDay += "</div>";
                usersperDay += "<div class='dash-widget-info'>";
                usersperDay += "<h3>" + countPerDay + "</h3>";
                usersperDay += "<h6 class='text-muted'>Total S-Interior Uses</h6>";
                usersperDay += "<div class='progress progress-sm'>";
                usersperDay += "<div class='progress-bar bg-primary w-50'></div>";
                usersperDay += "</div>";
                usersperDay += "</div>";
                usersperDay += "</div>";
                usersperDay += "</div>";
                usrPer.InnerHtml = usersperDay;

                // Listing the total Interios 
                dynamic interiorDis = "";
                dynamic inter = sr.liestDesigns("","");
                int countInterio = 0;
                foreach( InteriorTable pr in inter)
                {
                    countInterio += 1;
                }
                interiorDis += "<div class='card'>";
                interiorDis += "<div class='card-body'>";
                interiorDis += "<div class='dash-widget-header'>";
                interiorDis += "<span class='dash-widget-icon bg-success'>";
                interiorDis += "<i class='fe fe-money'></i>";
                interiorDis += "</span>";
                interiorDis += "</div>";
                interiorDis += "<div class='dash-widget-info'>";
                interiorDis += "<h3>"+countInterio+"</h3>";
                interiorDis += "<h6 class='text-muted'>Interiors</h6>";
                interiorDis += "<div class='progress progress-sm'>";
                interiorDis += "<div class='progress-bar bg-success w-50'></div>";
                interiorDis += "</div>";
                interiorDis += "</div>";
                interiorDis += "</div>";
                interiorDis += "</div>";

                interiorHtm.InnerHtml = interiorDis;


            dynamic total= sr.listAllInvoice("", 0);
            string shotot = "";
            string toReve = "";
            double totsales = 0;
            double tax = 0;
            foreach(InvoiceTable i in total)
            {
                totsales += Convert.ToDouble(i.TotalPrice);
                tax += Convert.ToDouble(i.Tax);
            }
           
            shotot += "<h3>R "+totsales+"</h3>";
            shotot += "<h6 class='text-muted'>Revenue Sales</h6>";
            shotot += "<div class='progress progress-sm'>";
            shotot += "<div class='progress-bar bg-warning w-50'></div>";
            shotot += "</div>";
            showTot.InnerHtml += shotot;


            toReve += "<h3>R " + (totsales-tax) + "</h3>";
            toReve += "<h6 class='text-muted'>Sales</h6>";
            toReve += "<div class='progress progress-sm'>";
            toReve += "<div class='progress-bar bg-dangerw-50'></div>";
            toReve += "</div>";
            totaSale.InnerHtml = toReve;






        }
    }
}