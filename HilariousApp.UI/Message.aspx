<%@ Page Title="Message" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="Message.aspx.cs" Inherits="HilariousApp.UI.Message" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
    <asp:DataGrid ID="dgMessage" runat="server" CssClass="table table-striped table-hover" GridLines="None" CellSpacing="-1"
        BorderWidth="0" />
</asp:Content>
