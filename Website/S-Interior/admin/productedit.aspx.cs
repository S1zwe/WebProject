using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using S_Interior.FinalService;
namespace S_Interior.admin
{
    public partial class productedit : System.Web.UI.Page
    {
        FunctionsClient sr = new FunctionsClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["IntID"]!= null)
            {
                int id = Convert.ToInt16(Session["IntID"]);
                string imagedisp = "";
                dynamic interior = sr.getAboutInterior(id);
                string filepart = "../img/blog/";
                string extention = ".jpg";
                string fpath = "../img/product/";
                string information = "";
                string discrib = "";

                foreach (InteriorTable i in interior)
                {
                    imagedisp += "<div class='pro-image' id='pro_popup'>";
                    imagedisp += "<a href='"+filepart+i.Image+extention+"'>";
                    imagedisp += "<img class='img-fluid' src='"+filepart+i.Image+extention+"' alt='Product Image'>";
                    imagedisp += "</a>";
                    imagedisp += "</div>";
                    information += "<h2>"+i.Name+"</h2>";
                    information += "<p class='product_price'>Product ID: "+i.Id+"</p>";
                    information += "<p class='product_price'>R:"+i.TotalPrice+"</p>";
                    if(i.Available == 1)
                    {
                        information += "<p><b>Availability:</b> In Stock</p>";
                    }
                    else
                    {
                        information += "<p><b>Availability:</b>Out Of Stock</p>";
                    }
                    discrib = "<p>"+i.Description+"</p>";
                }
                informationDisp.InnerHtml = information;
                ImageDisplay.InnerHtml = imagedisp;
                Discrib.InnerHtml = discrib;

                dynamic furnitures = sr.listFuniture(id);
                string smallPicturs = "";
                
                foreach (FurnitureTable f in furnitures)
                {
                    smallPicturs += "";
                    smallPicturs += "<li>";
                    smallPicturs += "<a href='"+fpath+f.Image+extention+"'><img src='" + fpath+f.Image+extention+"' alt='Product Image'></a>";
                    smallPicturs += "</li>";
                }
                smalImages.InnerHtml = smallPicturs;
            }
            else
            {
              Response.Redirect("interios.aspx");
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
           
            if( TextBox1.Text != "")
            {
                int num = Convert.ToInt16(TextBox1.Text);
                sr.DeleteInterior(Convert.ToInt16(Session["IntID"]), num);
                
            }else
            {
                Response.Redirect("productedit.aspx");
            }

        }
       
    }
}