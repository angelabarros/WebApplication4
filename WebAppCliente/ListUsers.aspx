<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListUsers.aspx.cs" Inherits="WebAppCliente.ListUsers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


     <h1 style="text-align:center;margin-top: 40px; text-size-adjust:100%;"> List of Users</h1>

    <div>
        <asp:GridView ID="gd1" runat="server"   RenderMode="Auto" style="width:1200px; margin-top:50px;" AutoGenerateColumns="False"
             DataKeyNames="Name,Email,Role"
             
             AutoGenerateEditButton="True" CellPadding="4" HorizontalAlign="Center" EnablePersistedSelection="True" ForeColor="#333333" GridLines="None" OnRowEditing="RowEditing" Width="800px">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField HeaderText="Name" DataField="Name"  ItemStyle-Width="370px"/>
                <asp:BoundField HeaderText="Email" DataField="Email" ItemStyle-Width="370px"/>
                <asp:BoundField HeaderText="Role" DataField="Role" ItemStyle-Width="370px"/>


            </Columns>


            <EditRowStyle BackColor="#2461BF" />
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
        <asp:Button ID="btn_createUser" runat="server" Text="Create New User" style="margin-left:1040px; margin-top:50px;  width:150px;" OnClick="btn_createUser_Click" />
        <br />
        <br />
  


    </div>

</asp:Content>
