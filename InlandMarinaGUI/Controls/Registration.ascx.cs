using InlandMarina.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InlandMarinaGUI.Controls
{
    public partial class Registration : System.Web.UI.UserControl
    {
        public bool IsUpdate { get; set; } // distinguishes update from add
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsUpdate)
            {
                // display current data values for the registration
                if (Session["CustomerID"] != null)
                {
                    // get customer ID out of the Session
                    int id = Convert.ToInt32(Session["CustomerID"]);

                    // get authentication record for this student
                    Authentication auth = AuthenticationManager.Find(id);
                    if (auth != null)
                    {
                        // display data in wizard's textboxes
                        txtFirstName.Text = auth.Customer.FirstName;
                        txtLastName.Text = auth.Customer.LastName;
                        txtPhone.Text = auth.Customer.Phone;
                        txtCity.Text = auth.Customer.City;
                        txtUsername.Text = auth.Username;
                        txtPassword.Text = auth.Password;
                    }
                }
            }
        }


        // submit button for the wizard
        protected void Wizard1_FinishButtonClick(object sender, WizardNavigationEventArgs e)
        {
            if (IsUpdate)
            {
                // get the customer id out of the Session
                int id = Convert.ToInt32(Session["StudentID"]);
                Authentication auth = AuthenticationManager.Find(id);
                // set values in this record using text boxes
                auth.Customer.FirstName = txtFirstName.Text;
                auth.Customer.LastName = txtLastName.Text;
                auth.Customer.Phone = txtPhone.Text;
                auth.Customer.City = txtCity.Text;
                auth.Username = txtUsername.Text;
                auth.Password = txtPassword.Text;
                AuthenticationManager.Update(auth); // pass to the manager class for update
                // force the user to log in again after update
                FormsAuthentication.SignOut();
                Session.Clear();
                Response.Redirect("~/Login");
            }
            else // Add - need to insert a new authentication record with data from the textboxes
            {
                Authentication auth = new Authentication
                {
                    Username = txtUsername.Text,
                    Password = txtPassword.Text,
                    Customer = new Customer
                    {
                        FirstName = txtFirstName.Text,
                        LastName = txtLastName.Text,
                        Phone = txtPhone.Text,
                        City = txtCity.Text
                    }

                };
                AuthenticationManager.Add(auth); // pass to the manager class for insert(Add)
                Response.Redirect("~/Login"); // give the user the opportunity to log in
            }
        }
    }
}