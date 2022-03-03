<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SlipSelector.ascx.cs" Inherits="InlandMarinaGUI.Controls.SlipSelector" %>
<h2>Select a Slip</h2>
<asp:Label ID="Label1" runat="server" Text="Dock A:"></asp:Label>
<asp:DropDownList ID="ddlSlipsA" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlSlipsA_SelectedIndexChanged"></asp:DropDownList>
<asp:Label ID="Label2" runat="server" Text="Dock B:"></asp:Label>
<asp:DropDownList ID="ddlSlipsB" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlSlipsB_SelectedIndexChanged"></asp:DropDownList>
<asp:Label ID="Label3" runat="server" Text="Dock C:"></asp:Label>
<asp:DropDownList ID="ddlSlipsC" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlSlipsC_SelectedIndexChanged"></asp:DropDownList>