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
                <asp:TextBox  id="txt_Amount" class="form-control" runat="server"></asp:TextBox>
            </div>

            <div class="form-group">
                <label for="exampleFormControlInput1">Description</label>
                <asp:TextBox  id="txt_Description" class="form-control" runat="server"></asp:TextBox>
            </div>

            <div class="form-group form-check">
                <label for="exampleFormControlInput1">Who used it</label>
                <asp:CheckBoxList ID="chb_HoUsedIt" runat="server"></asp:CheckBoxList>
            </div>

        <br><br>
        <asp:Button ID="btn_Submit" runat="server" OnClick="Btn_Save_Click" Text="Submit" class="btn btn-primary" />

        <br/><br/><br/>

        <asp:GridView ID="gdc_Expenses" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px"
            CellPadding="3" ForeColor="Black" GridLines="Vertical" Width="100%"
            OnRowDataBound="gdc_Expenses_RowDataBound">
            <AlternatingRowStyle BackColor="#CCCCCC" />
            <Columns>
                <asp:BoundField DataField="Cod_Expense" ItemStyle-Width="0" />
                <asp:BoundField DataField="Cod_User" HeaderText="Who"/>
                <asp:BoundField DataField="Amount" HeaderText="Amount" />
                <asp:BoundField DataField="Description" HeaderText="Description" />
                <asp:TemplateField HeaderText="WhoUsed" />
                <asp:TemplateField HeaderText="Percapita" />
            </Columns>
            <FooterStyle BackColor="#CCCCCC" />
            <HeaderStyle BackColor="#404040" Font-Bold="True" ForeColor="White" BorderStyle="Solid" BorderColor="#404040"/>
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#808080" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#383838" />
        </asp:GridView>
    </div>

</asp:Content>
