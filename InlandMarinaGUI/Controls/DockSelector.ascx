<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="DockSelector.ascx.cs" Inherits="InlandMarinaGUI.Controls.DockSelector" %>
<h2>Select a Dock</h2>
<asp:DropDownList ID="ddlDocks" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlDocks_SelectedIndexChanged"></asp:DropDownList>
<br />
