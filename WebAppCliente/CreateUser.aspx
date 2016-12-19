<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateUser.aspx.cs" Inherits="WebAppCliente.CreateUser1" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>

        <h1>Create New User</h1>
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
    <td><asp:TextBox ID="txtPass" runat="server" Width="700px" TextMode="Password"
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
    </form>
</body>

</html>
     