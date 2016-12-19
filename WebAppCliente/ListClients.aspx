<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListClients.aspx.cs" Inherits="WebAppCliente.ListClients" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    

  
      <h1 style="text-align:center;margin-top: 40px; text-size-adjust:100%;"> List of Clients </h1>
    <div>
        <asp:GridView ID="gd1" runat="server"  RenderMode="Auto" style="width:1200px; margin-top:50px;" AutoGenerateColumns="False"
             DataKeyNames="Name,Email"
             
             AutoGenerateEditButton="True" CellPadding="4"   HorizontalAlign="Center"  EnablePersistedSelection="True" ForeColor="#333333" GridLines="None" RowStyle-Wrap="false" OnRowEditing="RowEditing">
            <AlternatingRowStyle BackColor="White" />
     
            <Columns>
                <asp:BoundField HeaderText="Name" DataField="Name" ItemStyle-Width="550px"/>
                <asp:BoundField HeaderText="Email" DataField="Email" ItemStyle-Width="550px" />

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
        <br />
        <asp:Button ID="btn_newClient" style="margin-left:1050px; width:150px; margin-top:50px;" runat="server" Text="New Client" OnClick="btn_newClient_Click"  />
        <br />
  


    </div>
  
</asp:Content>
