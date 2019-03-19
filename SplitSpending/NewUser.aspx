<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="NewUser.aspx.cs" Inherits="SplitSpending._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h2>New User</h2><br>

        <div class="form-group">
            <label for="exampleFormControlInput1">Name</label>
            <asp:TextBox  id="name" runat="server" class="form-control"></asp:TextBox>
        </div>

        <div class="form-group">
            <label for="exampleFormControlInput1">Bank Account</label>
            <asp:TextBox  id="bankAccount" class="form-control" runat="server"></asp:TextBox>

        </div>
        <br><br>
        <asp:Button ID="Btn_Save" runat="server" OnClick="Btn_Save_Click" Text="Submit" class="btn btn-primary" />
    </div>
<%--    <div class="jumbotron">
        <h2>Users</h2><br>
        <table class="table">
          <thead>
            <tr>
              <th scope="col">#</th>
              <th scope="col">First</th>
              <th scope="col">Last</th>
              <th scope="col">Handle</th>
            </tr>
          </thead>
          <tbody>
            <tr>
              <th scope="row">1</th>
              <td>Mark</td>
              <td>Otto</td>
              <td>@mdo</td>
            </tr>
            <tr>
              <th scope="row">2</th>
              <td>Jacob</td>
              <td>Thornton</td>
              <td>@fat</td>
            </tr>
            <tr>
              <th scope="row">3</th>
              <td>Larry</td>
              <td>the Bird</td>
              <td>@twitter</td>
            </tr>
          </tbody>
        </table>

    </div>--%>

</asp:Content>
