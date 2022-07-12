<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebSite.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h1>Login</h1>
    <asp:TextBox ID="uEmail" type="email" runat="server" placeholder="email: "></asp:TextBox><br />
    <asp:TextBox ID="password" type="password" runat="server" placeholder="password: "></asp:TextBox><br />
    <asp:Button ID="btnLogin" runat="server" CssClass="btn btn-success" Text="Login" OnClick="btnLogin_Click" /><br />
    <asp:Label ID="errorMsg" runat="server" Text=""></asp:Label>

</asp:Content>
