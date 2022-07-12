<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="UrlView.aspx.cs" Inherits="WebSite.UrlView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <table id="tableView" runat="server" class="table table-striped">
      <thead>
        <tr>
          <th scope="col">ID</th>
          <th scope="col">Url End</th>
          <th scope="col">Big Url</th>
          <th scope="col">Small Url</th>
        </tr>
      </thead>
      <tbody>
        <tr>
            <th scope="row"><asp:Label ID="uId" runat="server" Text="Label"></asp:Label></th>
            <td><asp:Label ID="urldId" runat="server" Text="Label"></asp:Label></td>
            <td><asp:Label ID="bigUrl" runat="server" Text="Label"></asp:Label></td>
            <td><asp:Label ID="smallUrl" runat="server" Text="Label"></asp:Label></td>
        </tr>
      </tbody>
    </table>
    <asp:Label ID="errorMsg" runat="server" Text=""></asp:Label>

</asp:Content>
