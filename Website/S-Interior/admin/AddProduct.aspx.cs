using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using S_Interior.FinalService;


namespace S_Interior.admin
{


    public partial class AddProduct : System.Web.UI.Page
    {

        FunctionsClient sr = new FunctionsClient();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            if( Name.Value !="" && Description.Value !="" && ImageTX.Value !="" && TotalPrice.Value !="" && TotalPrice.Value !="" && Description.Value != null )
            { 
              
                classInterior newInterior = new classInterior
                {
                    name = Name.Value,
                    Description = Description.Value,
                    imge = ImageTX.Value,
                    price = Convert.ToInt16(TotalPrice.Value),
                    roomType = Roomtype.Value,
                    cateory = Designtype.Value,
                };
                bool upload = sr.addNewInterior(newInterior);
            }
           
        }
    }
}