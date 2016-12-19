<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CreateUser_mp.aspx.cs" Inherits="WebAppCliente.CreateUser_mp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
      <link href="StyleSheetTeste.css" rel="stylesheet" type="text/css">

    <div>

        <h1 style="text-align:center; margin-top:50px;">Create New User</h1>
          <table style="width:1200px; margin-top:50px;">
     <tr>
     <td style="width: 150px">Name:<br />
         <br />
         </td>
    <td style="width:1000px"><asp:TextBox class="txtbox" ID="txtName" runat="server" style="max-width:700px;"></asp:TextBox>
        <br />
        <br />
     </td>
     <td><asp:RequiredFieldValidator ID="rfvName" 
                 runat="server" 
                ControlToValidate="txtName"
                ErrorMessage="Name can't be left blank" 
                SetFocusOnError="True">*
         </asp:RequiredFieldValidator>
    </td>
    </tr>
     
    <tr><td style="width: 150px">Email:<br />
        <br />
        </td>
    <td style="width: 1000px"><asp:TextBox class="txtbox"  ID="txtEmail" runat="server" style="max-width:700px;"></asp:TextBox>
        <br />
        <br />
    </td>
   <td><asp:RequiredFieldValidator 
             ID="rfvEmail" 
             runat="server" 
             ControlToValidate="txtEmail"
             ErrorMessage="Email can't be left blank" 
             SetFocusOnError="True">*
        </asp:RequiredFieldValidator>
    </td></tr>
    




               <tr><td style="width: 150px"> Password:<br />
       </td>
    <td style="width: 1000px"><asp:TextBox  class="txtbox" ID="txtPass" runat="server" style="max-width:700px;" TextMode="Password" 
                     ></asp:TextBox>
        <br />
   </td>
    <td><asp:RequiredFieldValidator ID="Pass_validator" 
             runat="server" ControlToValidate="txtPass"
             ErrorMessage="Password can't be left blank" 
             SetFocusOnError="True">*
       </asp:RequiredFieldValidator>
    </td></tr>
            


               <tr><td style="width: 150px; height: 40px;"> 
                   <br />
                   Role:<br />
       <br />
       </td>


           
                   <td style="height: 40px">
                     
                    <asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatLayout="Table" RepeatDirection="Horizontal">

                      <asp:ListItem Id="rb_admin" Value="Admin" Text="Administrator" style="margin-right:50px"> </asp:ListItem>
                      <asp:ListItem Id="rb_emp" Value="Employee" Text="Employee" style="margin-right:30px"> </asp:ListItem>
               


                  </asp:RadioButtonList>
              
                   </tr>
             


             
                   <td style="height: 40px">
                       <br />
                       <asp:Button ID="Button_createUser" runat="server" Text="Create User" OnClick="Button_createUser_Click" />
                   </td>
          
    
                       
               </table>
    
    </div>



</asp:Content>
