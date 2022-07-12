<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="UrlUpdate.aspx.cs" Inherits="WebSite.UrlUpdate" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div id="divHideAdd1" runat="server">id: <asp:Label ID="id" runat="server" Text=""></asp:Label><br /></div>
    <div id="divHideAdd2" runat="server">small url: <asp:Label ID="smallUrl" runat="server" Text=""></asp:Label><br /></div>
    url end: <asp:TextBox ID="urlId" runat="server"></asp:TextBox><br />
    big url:<asp:TextBox ID="bigUrl" runat="server"></asp:TextBox><br />
    <asp:Button ID="btnAdd" runat="server" CssClass="btn btn-success" Text="Add" OnClick="btnAdd_Click" Visible="false" /><br />
    <asp:Button ID="btnUpdate" runat="server" CssClass="btn btn-warning" Text="Update" OnClick="btnUpdate_Click" Visible="false" /><br />
    <asp:Button ID="btnDelete" runat="server" CssClass="btn btn-danger" Text="Delete" OnClick="btnDelete_Click" Visible="false" /><br />
    <asp:Label ID="errorMsg" runat="server" Text=""></asp:Label>

</asp:Content>
