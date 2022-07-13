<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebSite.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <center>
        <h1>Welcome to Shrinker!!</h1>
        <asp:TextBox ID="bigUrl" placeholder="shrink url: " runat="server"></asp:TextBox><br />
        <asp:Label ID="shrinkedUrl" runat="server" Text=""></asp:Label><br />
        <asp:Button ID="shrinkUrl" CssClass="btn btn-success" runat="server" Text="Shrink" OnClick="shrinkUrl_Click" />
        <br />
        <br />
        <asp:TextBox ID="smallUrl" placeholder="enlarge url: " runat="server"></asp:TextBox><br />
        <asp:Label ID="enlargedUrl" runat="server" Text=""></asp:Label><br />
        <asp:Button ID="enlargeUrl" CssClass="btn btn-success" runat="server" Text="Enlarge" OnClick="enlargeUrl_Click" />
    </center>

</asp:Content>
