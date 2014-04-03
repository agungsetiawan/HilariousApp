<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CustomField.ascx.cs" Inherits="HilariousApp.UI.Controls.CustomField" %>
<div class="form-group">
    <asp:Label ID="label" runat="server" />
    <asp:TextBox ID="text" runat="server" CssClass="form-control"/>
    <asp:RequiredFieldValidator ID="validator" runat="server" 
        ControlToValidate="text" CssClass="label label-danger" Text="* Error"/>
</div>