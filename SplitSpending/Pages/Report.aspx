<%@ Page Title="Report" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Report.aspx.cs" Inherits="SplitSpending.Report" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">

        <h2>Report</h2><br>
        <asp:GridView ID="gdv_Expenditures" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="Solid"
            BorderWidth="1px" CellPadding="5" CellSpacing="0" ForeColor="Black" GridLines="Horizontal" AutoGenerateColumns="False" Width="100%"
            OnRowDataBound = "gdv_Expenditures_OnRowDataBound" AllowSorting="True">
            <Columns>
                <asp:BoundField DataField="Cod_User_Pay" HeaderText="Will Recieve" />
                <asp:BoundField DataField="Cod_User_Used" HeaderText="From" />
                <asp:BoundField DataField="Amount" HeaderText="Amount" />
            </Columns>

            <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
            <HeaderStyle BackColor="#404040" Font-Bold="True" ForeColor="White" BorderStyle="Solid" BorderColor="#404040"/>
            <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
            <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F7F7F7" />
            <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
            <SortedDescendingCellStyle BackColor="#E5E5E5" />
            <SortedDescendingHeaderStyle BackColor="#242121" />
        </asp:GridView>

    </div>

</asp:Content>
