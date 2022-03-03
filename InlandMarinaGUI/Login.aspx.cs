using InlandMarina.Data;
using Microsoft.Security.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.Security.AntiXss;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InlandMarinaGUI
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAuthenticate_Click(object sender, EventArgs e)
        {
            //string Name = AntiXssEncoder.HtmlEncode(Request.QueryString["Name"]);
            // pass login credentials to AuthenticationManager
            CustomerDTO customer = AuthenticationManager.
                Authenticate(txtUserName.Text, txtPassword.Text);
            if (customer == null) // failed authentication
            {
                lblMessage.Text = "Invalid login";
                txtUserName.Text = "";
                txtPassword.Text = "";
                txtUserName.Focus();
            }
            else // success
            {
                // preserve customer id in the session for possible update registration
                Session.Add("CustomerID", customer.ID);
                //Session["CustomerID"] = customer.ID;

                // redirect to original page that was requested
                FormsAuthentication.RedirectFromLoginPage(customer.FullName, false);
                // the first argument is what goes into authentication ticket,
                // second argument false means dont's create persistent cookie
            }
        }
    }
}