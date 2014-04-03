<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="HilariousApp.UI.Contact" %>
<%@ Register Src="~/Controls/CustomField.ascx" TagName="CustomField" TagPrefix="cf" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">

       
            <asp:Label ID="success" runat="server" CssClass="label label-success"/>
            <cf:CustomField ID="name" runat="server" LabelValue="Name :" InputMode="SingleLine" Message="Name Cannot Be Empty"/>
            <cf:CustomField ID="email" runat="server" LabelValue="Email :" InputMode="Email" IsRequired="false"/>
            <cf:CustomField ID="message" runat="server" LabelValue="Message :" InputMode="MultiLine" Message="Message Cannot be Empty"/>
            <asp:Button ID="button" runat="server" Text="Submit" CssClass="btn btn-primary" OnClick="button_Click" />
      

</asp:Content>
