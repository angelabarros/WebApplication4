<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SelectSources.aspx.cs" Inherits="WebAppCliente.SelectSources" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1 style="text-align:center;">Select Sources</h1>

    <h3 style="text-align:center;">Step 1 of 3</h3>


    <h4 style="text-align:center; margin-top:50px;">Files</h4>
    <asp:GridView ID="GridView1" runat="server" AllowSorting="True" CellPadding="4" ForeColor="#333333" style="margin-top:20px;" HorizontalAlign="Center" AutoGenerateSelectButton="True">
        <AlternatingRowStyle BackColor="White" />
      
            <FooterStyle BackColor="#FCDA00" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#FCDA00" Font-Bold="True" ForeColor="Black" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center"  />
            <RowStyle BackColor="#FFFAE5" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />

    </asp:GridView>


    <h4 style="text-align:center;margin-top:50px;">Templates</h4>
    <asp:GridView ID="GridView2" runat="server" AllowSorting="True" CellPadding="4" ForeColor="#333333" style="margin-top:20px;" HorizontalAlign="Center" AutoGenerateSelectButton="True">
        <AlternatingRowStyle BackColor="White" />
       
    <FooterStyle BackColor="#FCDA00" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#FCDA00" Font-Bold="True" ForeColor="Black" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center"  />
            <RowStyle BackColor="#FFFAE5" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
    </asp:GridView>

    <br />
    <asp:Button style="border-radius:0px 20px 20px 0px; height:28px; width:100px;margin-top:30px; margin-left:1000px;" ID="Button1" runat="server" OnClick="Button1_Click" Text="Next" />

    
</asp:Content>
