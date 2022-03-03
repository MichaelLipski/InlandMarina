<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="InlandMarinaGUI.Registration" %>

<%@ Register Src="~/Controls/Registration.ascx" TagPrefix="uc1" TagName="Registration" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Register Here</h2>
    <uc1:Registration runat="server" ID="uxRegistration" />
</asp:Content>
