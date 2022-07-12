<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="UserUpdate.aspx.cs" Inherits="WebSite.UserUpdate" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div id="userIdDiv" runat="server"> id: <asp:Label ID="uId" runat="server" Text="Label"></asp:Label><br /></div>
    first name: <asp:TextBox ID="fName" runat="server"></asp:TextBox><br />
    last name: <asp:TextBox ID="lName" runat="server"></asp:TextBox><br />
    email: <asp:TextBox ID="uEmail" runat="server"></asp:TextBox><br />
    pass: <asp:TextBox ID="password" runat="server"></asp:TextBox><br />
    <asp:Button ID="btnAdd" runat="server" CssClass="btn btn-success" Text="Add" OnClick="btnAdd_Click" Visible ="false" /><br />
    <asp:Button ID="btnUpdate" runat="server" CssClass="btn btn-warning" Text="Update" OnClick="btnUpdate_Click" Visible ="false" /><br />
    <asp:Button ID="btnDelete" runat="server" CssClass="btn btn-danger" Text="Delete" OnClick="btnDelete_Click" Visible ="false" /><br />
    <asp:Label ID="errorMsg" runat="server" Text=""></asp:Label>
</asp:Content>
