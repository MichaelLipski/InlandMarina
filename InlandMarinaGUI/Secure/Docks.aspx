<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Docks.aspx.cs" Inherits="InlandMarinaGUI.Secure.Docks" %>

<%@ Register Src="~/Controls/DockSelector.ascx" TagPrefix="uc1" TagName="DockSelector" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Our Dock Options</h2>
    <br />
    <uc1:DockSelector runat="server" id="DockSelector" AllowAutoPostBack="True" />
    
    <div class="col-md-7">
        <table class ="table">
            <tr>
                <td style ="width:150px">Dock ID:</td>
                <td>
                    <asp:Label ID="lblDockId" runat="server" Text=""></asp:Label></td>
            </tr>
            <tr>
                <td>Dock Name:</td>
                <td><asp:Label ID="lblName" runat="server" Text=""></asp:Label></td>
            </tr>
            <tr>
                <td>Water Service:</td>
                <td><asp:Label ID="lblWater" runat="server" Text=""></asp:Label></td>
            </tr>
            <tr>
                <td>Electrical Service:</td>
                <td><asp:Label ID="lblElectrical" runat="server" Text=""></asp:Label></td>
            </tr>
        </table>
    </div>

</asp:Content>
