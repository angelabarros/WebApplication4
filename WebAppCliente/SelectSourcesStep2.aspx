<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SelectSourcesStep2.aspx.cs" Inherits="WebAppCliente.SelectSourcesStep2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

     
    <h1 style="text-align:center;">Select Sources</h1>

    <h3 style="text-align:center;">Step 2 of 3</h3>

  
            <h5 style="text-align:center">All Tags From Template</h5>
            <asp:GridView ID="gd1" runat="server" HorizontalAlign="Center" RenderMode="Auto" style=" margin-top:20px;" AutoGenerateColumns="False"
             DataKeyNames="Name" CellPadding="4"    EnablePersistedSelection="True" ForeColor="#333333" GridLines="Vertical" RowStyle-Wrap="false" Width="700px" >
            <AlternatingRowStyle BackColor="White" />
     
            <Columns>
                 <asp:TemplateField>
            <ItemTemplate>
                <asp:CheckBox ID="chkRow" runat="server" />
            </ItemTemplate>
        </asp:TemplateField>
                <asp:BoundField HeaderText="Name" DataField="Name" ItemStyle-Width="700px">
               
           

<ItemStyle Width="700px"></ItemStyle>
                </asp:BoundField>

            <asp:BoundField HeaderText="Status" DataField="Status" ItemStyle-Width="50px"> 

                <ItemStyle Width="50px"></ItemStyle>
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


        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Next" style="float:right; margin-top:50px; width:100px; margin-left:10px;" Width="120px" />


    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Change Status" style="float:right; margin-top:50px;" Width="120px" />


</asp:Content>
