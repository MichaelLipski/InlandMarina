using InlandMarina.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InlandMarinaGUI.Secure
{
    public partial class MyLeases : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // display current data values for the registration
            if (Session["CustomerID"] != null)
            {
                // get customer ID out of the Session
                int id = Convert.ToInt32(Session["CustomerID"]);

                // get authentication record for this customer
                Authentication auth = AuthenticationManager.Find(id);
                if (auth != null)
                {
                    List<Lease> leases = (List<Lease>)MarinaManager.GetLeasesByCustomer(id);
                    gvMyLeases.DataSource = leases;
                    gvMyLeases.DataBind();
                }
            }
        }
    }
}