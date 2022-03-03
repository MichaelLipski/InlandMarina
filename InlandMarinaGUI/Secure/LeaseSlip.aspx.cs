using InlandMarina.Data;
using InlandMarinaGUI.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InlandMarinaGUI.Secure
{
    public partial class LeaseSlip : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SlipSelector.SlipSelect += SlipSelector_SlipSelect; //subscribe to the event
        }
        // method to handle the event SlipSelect
        private void SlipSelector_SlipSelect(object sender, Controls.SlipEventArgs e)
        {
            lblSlipID.Text = e.ID;
            lblWidth.Text = e.Width;
            lblLength.Text = e.Length;

            // preserve the selected slip in Session state
            SlipSelector uc = (SlipSelector)sender;
            Session["Slip"] = uc.SelectedSlip;
        }

        protected void btnLease_Click(object sender, EventArgs e)
        {
            int SlipID = Convert.ToInt32(lblSlipID.Text);
            int CustomerID = (int)Session["CustomerID"];
            Authentication auth = AuthenticationManager.Find(CustomerID);
            // get selected slip into the new lease function
            MarinaManager.LeaseSlip(SlipID, CustomerID);
            // redirect to page with list of leases for this customer
            Response.Redirect("~/Secure/MyLeases");
        }
    }
}