using InlandMarina.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InlandMarinaGUI.Controls
{
    public partial class SlipSelector : System.Web.UI.UserControl
    {
        // declare event
        public event SlipSelectionHandler SlipSelect;

        // public properties
        public Slip SelectedSlip { get; set; }
        public bool AllowAutoPostBack // gives access to AutoPostBack property of the inner drop down list
        {
            get { return ddlSlipsA.AutoPostBack; }
            set { ddlSlipsA.AutoPostBack = value; }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // populate the drop down list
                ddlSlipsA.DataSource = MarinaManager.GetAvailableASlips();
                ddlSlipsA.DataValueField = "ID";
                ddlSlipsA.DataBind();
                ddlSlipsA.SelectedIndex = 0;
                // instantiate args for course 0 and invoke the SlipSelect event
            }

            if (!IsPostBack)
            {
                // populate the drop down list
                ddlSlipsB.DataSource = MarinaManager.GetAvailableBSlips();
                ddlSlipsB.DataValueField = "ID";
                ddlSlipsB.DataBind();
                ddlSlipsB.SelectedIndex = 0;
                // instantiate args for course 0 and invoke the SlipSelect event
            }

            if (!IsPostBack)
            {
                // populate the drop down list
                ddlSlipsC.DataSource = MarinaManager.GetAvailableCSlips();
                ddlSlipsC.DataValueField = "ID";
                ddlSlipsC.DataBind();
                ddlSlipsC.SelectedIndex = 0;
                // instantiate args for course 0 and invoke the SlipSelect event
            }
        }
        // user selected from the drop down list - we need to translate it into incoking the event of the user control
        protected void ddlSlipsA_SelectedIndexChanged(object sender, EventArgs e)
        {
            // fire the event SlipSelect
            if (SlipSelect != null) // if the event was subscribed to
            {
                // get the id from the drop down list
                int id = Convert.ToInt32(ddlSlipsA.SelectedValue);

                // find the course with this id
                Slip sps = MarinaManager.Find(id);
                // set SelectedCourse property
                SelectedSlip = sps;

                // instantiate the SlipEventArgs class
                SlipEventArgs arg = new SlipEventArgs
                {
                    ID = sps.ID.ToString(),
                    Width = sps.Width.ToString(),
                    Length = sps.Length.ToString(),
                    DockID = sps.DockID.ToString()
                };

                // invoke the event
                SlipSelect.Invoke(this, arg);
            }

        }

        protected void ddlSlipsB_SelectedIndexChanged(object sender, EventArgs e)
        {
            // fire the event SlipSelect
            if (SlipSelect != null) // if the event was subscribed to
            {
                // get the id from the drop down list
                int id = Convert.ToInt32(ddlSlipsB.SelectedValue);

                // find the course with this id
                Slip sps = MarinaManager.Find(id);
                // set SelectedCourse property
                SelectedSlip = sps;

                // instantiate the SlipEventArgs class
                SlipEventArgs arg = new SlipEventArgs
                {
                    ID = sps.ID.ToString(),
                    Width = sps.Width.ToString(),
                    Length = sps.Length.ToString(),
                    DockID = sps.DockID.ToString()
                };

                // invoke the event
                SlipSelect.Invoke(this, arg);
            }

        }

        protected void ddlSlipsC_SelectedIndexChanged(object sender, EventArgs e)
        {
            // fire the event SlipSelect
            if (SlipSelect != null) // if the event was subscribed to
            {
                // get the id from the drop down list
                int id = Convert.ToInt32(ddlSlipsC.SelectedValue);

                // find the course with this id
                Slip sps = MarinaManager.Find(id);
                // set SelectedCourse property
                SelectedSlip = sps;

                // instantiate the SlipEventArgs class
                SlipEventArgs arg = new SlipEventArgs
                {
                    ID = sps.ID.ToString(),
                    Width = sps.Width.ToString(),
                    Length = sps.Length.ToString(),
                    DockID = sps.DockID.ToString()
                };

                // invoke the event
                SlipSelect.Invoke(this, arg);
            }

        }
    }
}