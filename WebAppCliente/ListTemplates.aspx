<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListTemplates.aspx.cs" Inherits="WebAppCliente.ListTemplates" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1 style="text-align:center;"> Templates </h1>

    <div>
        <asp:GridView ID="gd1" runat="server"  RenderMode="Auto" style="width:1000px; margin-top:50px;" AutoGenerateColumns="False"
             DataKeyNames="Name" CellPadding="4"  HorizontalAlign="Center"  EnablePersistedSelection="True" ForeColor="#333333" GridLines="None" RowStyle-Wrap="false" Width="1000px" >
            <AlternatingRowStyle BackColor="White" />
     
            <Columns>
                <asp:BoundField HeaderText="Name" DataField="Name" ItemStyle-Width="600px">
           

<ItemStyle Width="1000px"></ItemStyle>
                </asp:BoundField>
           

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






        <asp:Button ID="btn_uploadNewTemp" runat="server" Text="Upload New Template" style="margin-top:50px; margin-left:930px;" OnClick="btn_uploadNewTemp_Click" />
    </div>
</asp:Content>
