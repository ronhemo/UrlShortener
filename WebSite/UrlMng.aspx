<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="UrlMng.aspx.cs" Inherits="WebSite.UrlMng" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    
    <table class="table table-striped">
      <thead>
        <tr>
          <th scope="col">ID</th>
          <th scope="col">Url End</th>
          <th scope="col">Big Url</th>
          <th scope="col">Small Url</th>
          <th scope="col">View</th>
          <th scope="col">Update/Delete</th>
          <th scope="col"><a href="UrlUpdate.aspx">Add</a></th>
        </tr>
      </thead>
      <tbody>

        <asp:Repeater ID="urlRepeater" runat="server">
            <ItemTemplate>
                <tr>
                    <th scope="row"><%#Eval("id") %></th>
                    <td><%#Eval("urlid") %></td>
                    <td><%#Eval("bigurl") %></td>
                    <td><%#Eval("smallurl") %></td>
                    <td><a class="btn btn-secondary" href="UrlView.aspx?id=<%#Eval("id") %>">View</a></td>
                    <td><a class="btn btn-warning" href="UrlUpdate.aspx?id=<%#Eval("id") %>">Update\Delete</a></td>
                    <td><a class="btn btn-success" href="UrlUpdate.aspx">Add</a></td>
                </tr>
            </ItemTemplate>

            <SeparatorTemplate>
            </SeparatorTemplate>
        </asp:Repeater>

      </tbody>
    </table>

</asp:Content>
