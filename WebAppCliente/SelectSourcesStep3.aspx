<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SelectSourcesStep3.aspx.cs" Inherits="WebAppCliente.SelectSourcesStep3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    
    <h1 style="text-align:center;">Select Sources</h1>

    <h3 style="text-align:center;">Step 3 of 3</h3>

    <table style="width: 1000px">
        <tr>
            <div style="text-align:center;">
                <asp:Label ID="Label1" runat="server" Text="Formula's name:"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </div>
            
        </tr>
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
            <td style="vertical-align:top; width: 174px;">

                <h5>Spreadsheets</h5>
            <asp:GridView ID="GridView2" runat="server"  RenderMode="Auto" style="width:150px; margin-left:0px; margin-top:5px;" AutoGenerateColumns="False"
             DataKeyNames="Name" CellPadding="4"    EnablePersistedSelection="True" ForeColor="#333333" GridLines="Vertical" RowStyle-Wrap="false" Width="100px" AutoGenerateSelectButton="True" OnSelectedIndexChanged="GridView2_SelectedIndexChanged" >
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
            

            <td style="vertical-align:top; width: 170px; text-align:center;">
                <h5>Operation</h5>
                    <asp:DropDownList  ID="DropDownList1_base" runat="server"></asp:DropDownList>
                 <div style="margin-top:30px;">
                      <asp:PlaceHolder ID="PlaceHolder4" runat="server"></asp:PlaceHolder>
                 </div>
            </td>


             <td style="vertical-align:top; margin-left:20px; width: 194px; text-align:center;">
                 <h5>Columns</h5>
                    <asp:DropDownList  ID="DropDownList2_base" runat="server"></asp:DropDownList>

                 <div style="margin-top:30px;">
                      <asp:PlaceHolder ID="PlaceHolder3" runat="server"></asp:PlaceHolder>
                 </div>
                


            </td>
        
            <td style="vertical-align:top;width: 223px; text-align:center;">
                <h5>Operator</h5>
                <asp:DropDownList  ID="DropDownList3_base" runat="server"></asp:DropDownList>

                <div style="margin-top:30px;">

                    <asp:PlaceHolder ID="PlaceHolder2" runat="server"></asp:PlaceHolder>

                </div>
                

            </td>
           

            <td style="vertical-align:top; width: 211px; text-align:center;">
                <h5>Condition</h5>
                 <asp:TextBox ID="TextBox1_base" runat="server"></asp:TextBox>

                <div style="margin-top:30px;">
                    <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
                </div>
                

            </td>

            <td style="vertical-align:top; width:129px; text-align:center;">
                <h5>Add</h5>
                <asp:Button ID="Button1_base" runat="server" Text="+" style="width:20px; height:24px;" OnClick="Button1_Click1"/>


            </td>

            <td style="vertical-align:bottom; width:129px; text-align:center;">
                <asp:Button ID="Button_submit" runat="server" Text="Submit" OnClick="Button_submit_Click" />

            </td>
            </tr>
        <tr>
             <div style="margin-top:30px;">
                 <asp:Label ID="LabelContent" runat="server"></asp:Label>
                </div>
                



        </tr>
        </table>
   
        






</asp:Content>
