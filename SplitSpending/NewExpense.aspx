<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="NewExpense.aspx.cs" Inherits="SplitSpending.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <h2>New Expense</h2><br><br>
            <div class="form-group">
                <label for="exampleFormControlSelect1">Who spent</label>
                <asp:DropDownList ID="ddl_WhoSpent" runat="server" class="form-control"></asp:DropDownList>
            </div>
               

            <div class="form-group">
                <label for="exampleFormControlInput1">Amount</label>
                <asp:TextBox  id="amount" class="form-control" runat="server"></asp:TextBox>
            </div>

            <div class="form-group form-check">
                <label for="exampleFormControlInput1">Who used it</label>
                <asp:CheckBoxList ID="chb_whoUsedIt" runat="server"></asp:CheckBoxList>
            </div>

        <br><br>
        <asp:Button ID="Btn_Submit" runat="server" OnClick="Btn_Save_Click" Text="Submit" class="btn btn-primary" />
    </div>
</asp:Content>
