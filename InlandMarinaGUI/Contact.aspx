<%@ Page Title="Contact Us" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="InlandMarinaGUI.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Let us know how we can help!</h3>
        <address>
            <strong>Inland Lake Marina</strong><br />
            Box 123<br />
            Inland Lake, Arizona 86038<br /><br />

            <strong>Office Phone</strong> 928-555-2234<br />
            <strong>Leasing Phone</strong> 928-555-2235<br />
            <strong>Fax</strong> 928-555-2236<br /><br />

            Manager: Glenn Cooke<br />
            Slip Manager: Kimberley Carson<br />

        </address>

        <address>
            <strong>Contact:</strong>   <a href="info@inlandmarina.com">info@inlandmarina.com</a><br />
        </address>
</asp:Content>
