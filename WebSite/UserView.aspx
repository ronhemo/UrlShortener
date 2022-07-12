<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="UserView.aspx.cs" Inherits="WebSite.UserView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <table id="tableView" runat="server" class="table table-striped">
      <thead>
        <tr>
          <th scope="col">ID</th>
          <th scope="col">First Name</th>
          <th scope="col">Last Name</th>
          <th scope="col">Email</th>
          <th scope="col">Password</th>
        </tr>
      </thead>
      <tbody>
        <tr>
            <th scope="row"><asp:Label ID="uId" runat="server" Text="Label"></asp:Label></th>
            <td><asp:Label ID="fName" runat="server" Text="Label"></asp:Label></td>
            <td><asp:Label ID="lName" runat="server" Text="Label"></asp:Label></td>
            <td><asp:Label ID="uEmail" runat="server" Text="Label"></asp:Label></td>
            <td><asp:Label ID="password" runat="server" Text="Label"></asp:Label></td>
        </tr>
      </tbody>
    </table>
    <asp:Label ID="errorMsg" runat="server" Text=""></asp:Label>

</asp:Content>
