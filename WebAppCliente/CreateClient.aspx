<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CreateClient.aspx.cs" Inherits="WebAppCliente.CreateClient" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
   
    <h1>&nbsp;Create New Client</h1>
    <p>&nbsp;</p>
    <p>&nbsp;</p>
    
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
    <tr>
    <td style="width: 206px">Address:<br />
        <br />
        </td>
    <td><asp:TextBox ID="txtAddress" runat="server" Width="700px"></asp:TextBox>
        <br />
        <br />
        </td>
    <td><asp:RequiredFieldValidator 
             ID="RequiredFieldValidator1" runat="server" 
             ControlToValidate="txtAddress"
             ErrorMessage="Address can't be left blank" 
             SetFocusOnError="True">*
        </asp:RequiredFieldValidator>
    </td></tr>
     
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
     

   <tr><td style="width: 206px">Domain:<br />
       <br />
       </td>
    <td><asp:TextBox ID="txtDomain" runat="server" Width="700px"
                     ></asp:TextBox>
        <br />
        <br />
   </td>
    <td><asp:RequiredFieldValidator ID="rfvDomain" 
             runat="server" ControlToValidate="txtDomain"
             ErrorMessage="Domain can't be left blank" 
             SetFocusOnError="True">*
       </asp:RequiredFieldValidator>
    </td></tr>



        <tr><td style="width: 206px">Telephone:<br />
       <br />
       </td>
    <td><asp:TextBox ID="txtTelephone" runat="server" Width="700px"
                     ></asp:TextBox>
        <br />
        <br />
   </td>
    <td><asp:RequiredFieldValidator ID="rfvTelephone" 
             runat="server" ControlToValidate="txtTelephone"
             ErrorMessage="Telephone can't be left blank" 
             SetFocusOnError="True">*
       </asp:RequiredFieldValidator>
    </td></tr>
     

 
     
       


       <tr><td style="width: 206px">Logo:<br />
       <br />
       </td>
    <td><asp:FileUpload ID="FileUpload_logo" runat="server" Width="700px" />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
   </td>
    </tr>

        <tr><td style="width: 206px">
            <asp:Button ID="Button_BACK" runat="server" Text="BACK" OnClick="Button_BACK_Click" />
            <br />
       <br />
       </td>
    <td>
            &nbsp;<asp:Button ID="Button_NEXT" runat="server" Text="NEXT" OnClick="Button_NEXT_Click" />
        <br />
        <br />
   </td>
    </tr>


        <tr><td style="width: 206px">
            &nbsp;</td>
    <td>
            
            </td>
    </tr>


  </table>
</asp:Content>
