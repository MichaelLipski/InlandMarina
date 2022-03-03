using InlandMarina.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InlandMarinaGUI.Controls
{
    public partial class DockSelector : System.Web.UI.UserControl
    {
        // declare event
        public event DockSelectionHandler DockSelect;

        // public properties
        public Dock SelectedDock { get; set; }
        public bool AllowAutoPostBack // gives access to AutoPostBack property of the inner drop down list
        {
            get { return ddlDocks.AutoPostBack; }
            set { ddlDocks.AutoPostBack = value; }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // populate the drop down list
                ddlDocks.DataSource = MarinaManager.GetAllAsListDockItems();
                ddlDocks.DataValueField = "ID";
                ddlDocks.DataTextField = "Name";
                ddlDocks.DataBind();
                ddlDocks.SelectedIndex = 0;
                // instantiate args for course 0 and invoke the DockSelect event
            }
        }

        // user selected from the drop down list - we need to translate it into incoking the event of the user control
        protected void ddlDocks_SelectedIndexChanged(object sender, EventArgs e)
        {
            // fire the event DockSelect
            if (DockSelect != null) // if the event was subscribed to
            {
                // get the id from the drop down list
                int id = Convert.ToInt32(ddlDocks.SelectedValue);

                // find the course with this id
                Dock doc = MarinaManager.FindDock(id);
                // set SelectedDock property
                SelectedDock = doc;

                // instantiate the DockEventArgs class
                DockEventArgs arg = new DockEventArgs
                {
                    ID = doc.ID.ToString(),
                    Name = doc.Name,
                    WaterService = doc.WaterService.ToString(),
                    ElectricalService = doc.ElectricalService.ToString()
                };

                // invoke the event
                DockSelect.Invoke(this, arg);
            }

        }
    }
}