<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LeaseSlip.aspx.cs" Inherits="InlandMarinaGUI.Secure.LeaseSlip" %>

<%@ Register Src="~/Controls/SlipSelector.ascx" TagPrefix="uc1" TagName="SlipSelector" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Choose Your Slip from Dock A, B or C</h1>
    <br />
    
    <uc1:SlipSelector runat="server" id="SlipSelector" AllowAutoPostBack="True" />
    
    <div class="col-md-7">
        <table class ="table">
            <tr>
                <td style ="width:150px">Slip ID:</td>
                <td>
                    <asp:Label ID="lblSlipID" runat="server" Text=""></asp:Label></td>
            </tr>
            <tr>
                <td>Width of Dock in Feet:</td>
                <td><asp:Label ID="lblWidth" runat="server" Text=""></asp:Label></td>
            </tr>
            <tr>
                <td>Length of Dock in Feet:</td>
                <td><asp:Label ID="lblLength" runat="server" Text=""></asp:Label></td>
            </tr>
        </table>
        <asp:Button ID="btnLease" runat="server" Text="Lease This Slip" OnClick="btnLease_Click" />
    </div>

    <%--<br /><br /><br /><br /><br /><br /><br /><br />
    <h1>Lease a Slip From Dock B</h1>
    <br />
    <uc1:SlipSelector runat="server" id="SlipSelector1" AllowAutoPostBack="True" />
    
    <div class="col-md-7">
        <table class ="table">
            <tr>
                <td style ="width:150px">Slip ID:</td>
                <td>
                    <asp:Label ID="lblSlipIDB" runat="server" Text=""></asp:Label></td>
            </tr>
            <tr>
                <td>Width of Dock in Feet:</td>
                <td><asp:Label ID="lblWidthB" runat="server" Text=""></asp:Label></td>
            </tr>
            <tr>
                <td>Length of Dock in Feet:</td>
                <td><asp:Label ID="lblLengthB" runat="server" Text=""></asp:Label></td>
            </tr>
        </table>
    </div>

        <br /><br /><br /><br /><br /><br /><br /><br />
    <h1>Lease a Slip From Dock C</h1>
    <br />
    <uc1:SlipSelector runat="server" id="SlipSelector2" AllowAutoPostBack="True" />
    
    <div class="col-md-7">
        <table class ="table">
            <tr>
                <td style ="width:150px">Slip ID:</td>
                <td>
                    <asp:Label ID="lblSlipIDC" runat="server" Text=""></asp:Label></td>
            </tr>
            <tr>
                <td>Width of Dock in Feet:</td>
                <td><asp:Label ID="lblWidthC" runat="server" Text=""></asp:Label></td>
            </tr>
            <tr>
                <td>Length of Dock in Feet:</td>
                <td><asp:Label ID="lblLengthC" runat="server" Text=""></asp:Label></td>
            </tr>
        </table>
    </div>--%>


</asp:Content>
