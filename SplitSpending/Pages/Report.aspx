<%@ Page Title="Report" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Report.aspx.cs" Inherits="SplitSpending.Report" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">

        <h2>Report</h2><br>
        <asp:GridView ID="gdv_Expenditures" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="Solid"
            BorderWidth="1px" CellPadding="5" ForeColor="Black" GridLines="Vertical" AutoGenerateColumns="False" Width="100%"
            OnRowDataBound = "gdv_Expenditures_OnRowDataBound" AllowSorting="True">
            <AlternatingRowStyle BackColor="#CCCCCC" />
            <Columns>
                <asp:BoundField DataField="Cod_User_Pay" HeaderText="Will Recieve" />
                <asp:BoundField DataField="Cod_User_Used" HeaderText="From" />
                <asp:BoundField DataField="Amount" HeaderText="Amount" />
            </Columns>

            <FooterStyle BackColor="#CCCCCC" />
            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#808080" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#383838" />
        </asp:GridView>

    </div>

</asp:Content>
