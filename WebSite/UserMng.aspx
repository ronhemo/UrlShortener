<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="UserMng.aspx.cs" Inherits="WebSite.UserMng" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <table class="table table-striped">
      <thead>
        <tr>
          <th scope="col">ID</th>
          <th scope="col">First Name</th>
          <th scope="col">Last Name</th>
          <th scope="col">Email</th>
          <th scope="col">Password</th>
          <th scope="col">View</th>
          <th scope="col">Update/Delete</th>
          <th scope="col"><a href="UserUpdate.aspx">Add</a></th>
        </tr>
      </thead>
      <tbody>

        <asp:Repeater ID="userRepeater" runat="server">
            <ItemTemplate>
                <tr>
                    <th scope="row"><%#Eval("id") %></th>
                    <td><%#Eval("firstname") %></td>
                    <td><%#Eval("lastname") %></td>
                    <td><%#Eval("email") %></td>
                    <td><%#Eval("pass") %></td>
                    <td><a class="btn btn-secondary" href="UserView.aspx?userid=<%#Eval("id") %>">View</a></td>
                    <td><a class="btn btn-warning" href="UserUpdate.aspx?userid=<%#Eval("id") %>">Update\Delete</a></td>
                    <td><a class="btn btn-success" href="UserUpdate.aspx">Add</a></td>
                </tr>
            </ItemTemplate>

            <SeparatorTemplate>
            </SeparatorTemplate>
        </asp:Repeater>

      </tbody>
    </table>

</asp:Content>
