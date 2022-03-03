using InlandMarinaGUI.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InlandMarinaGUI.Secure
{
    public partial class Docks : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DockSelector.DockSelect += DockSelector_DockSelect; //subscribe to the event
        }

        // method to handle the event DockSelect
        private void DockSelector_DockSelect(object sender, Controls.DockEventArgs e)
        {
            lblDockId.Text = e.ID;
            lblName.Text = e.Name;
            lblWater.Text = e.WaterService;
            lblElectrical.Text = e.ElectricalService;

            // preserve the selected Dock in Session state
            DockSelector uc = (DockSelector)sender;
            Session["Dock"] = uc.SelectedDock;
        }
    }
}