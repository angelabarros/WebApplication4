<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SelectSourcesStep3.aspx.cs" Inherits="WebAppCliente.SelectSourcesStep3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    
    <h1 style="text-align:center;">Select Sources</h1>

    <h3 style="text-align:center;">Step 3 of 3</h3>
    <asp:DropDownList  ID="DropDownList1" runat="server"></asp:DropDownList>
    <table>
        <tr> 
        <td style="width: 266px">
            <h5>Tags</h5>
            <asp:GridView ID="gd1" runat="server"  RenderMode="Auto" style="width:250px; margin-left:0px; margin-top:5px;" AutoGenerateColumns="False"
             DataKeyNames="Name" CellPadding="4"    EnablePersistedSelection="True" ForeColor="#333333" GridLines="Vertical" RowStyle-Wrap="false" Width="200px" AutoGenerateSelectButton="True" >
            <AlternatingRowStyle BackColor="White" />
     
            <Columns>
                <asp:BoundField HeaderText="Name" DataField="Name" ItemStyle-Width="200px">
           

<ItemStyle Width="200px"></ItemStyle>
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
 </td>
            <td style="vertical-align:top;">

                <h5>Spreadsheets</h5>
            <asp:GridView ID="GridView2" runat="server"  RenderMode="Auto" style="width:150px; margin-left:0px; margin-top:5px;" AutoGenerateColumns="False"
             DataKeyNames="Name" CellPadding="4"    EnablePersistedSelection="True" ForeColor="#333333" GridLines="Vertical" RowStyle-Wrap="false" Width="100px" AutoGenerateSelectButton="True" >
            <AlternatingRowStyle BackColor="White" />
     
            <Columns>
                <asp:BoundField HeaderText="Name" DataField="Name" ItemStyle-Width="100px">
           

<ItemStyle Width="100px"></ItemStyle>
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

            </td>
            <td style="vertical-align:top;">

                 <h5>Columns</h5>
            <asp:GridView ID="GridView1" runat="server"  RenderMode="Auto" style="width:100px; margin-left:0px; margin-top:5px;" AutoGenerateColumns="False"
             DataKeyNames="Name" CellPadding="4"    EnablePersistedSelection="True" ForeColor="#333333" GridLines="Vertical" RowStyle-Wrap="false" Width="50px" AutoGenerateSelectButton="True" >
            <AlternatingRowStyle BackColor="White" />
     
            <Columns>
                <asp:BoundField HeaderText="Name" DataField="Name" ItemStyle-Width="50px">
           

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






            </td>
            </tr>
    </table>
   
        






</asp:Content>
