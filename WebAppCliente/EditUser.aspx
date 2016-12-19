<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditUser.aspx.cs" Inherits="WebAppCliente.EditUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

  
    <div>

        <h1>Edit User</h1>
        <asp:Label ID="Label_name_user" runat="server" Text="Label"></asp:Label>
          <table>
     <tr>
     <td style="width: 206px">Name:<br />
         <br />
         </td>
    <td><asp:TextBox ID="txtName" runat="server" Width="700px"></asp:TextBox>
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
     
    <tr><td style="width: 206px">Email:<br />
        <br />
        </td>
    <td><asp:TextBox ID="txtEmail" runat="server" Width="700px"></asp:TextBox>
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
    




               <tr><td style="width: 206px"> Password:<br />
       <br />
       </td>
    <td><asp:TextBox ID="txtPass" runat="server" Width="700px"
                     ></asp:TextBox>
        <br />
        <br />
   </td>
    <td><asp:RequiredFieldValidator ID="Pass_validator" 
             runat="server" ControlToValidate="txtPass"
             ErrorMessage="Password can't be left blank" 
             SetFocusOnError="True">*
       </asp:RequiredFieldValidator>
    </td></tr>
            


               <tr><td style="width: 206px"> 
                   <br />
                   Role:<br />
       <br />
       </td>


           
                   <td>
                     
                    <asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatLayout="Table" RepeatDirection="Horizontal">

                      <asp:ListItem Id="rb_admin" Value="Admin" Text="Administrator" style="margin-right:50px"> </asp:ListItem>
                      <asp:ListItem Id="rb_emp" Value="Employee" Text="Employee" style="margin-right:30px"> </asp:ListItem>
               


                  </asp:RadioButtonList>
              
                   </tr>
             


             
                   <td>
                       <br />
                       <asp:Button ID="Button_createUser" runat="server" Text="Create User" OnClick="Button_createUser_Click" />
                   </td>
          
    
                       
               </table>
    
    </div>





</asp:Content>
