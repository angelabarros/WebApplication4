<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebAppCliente.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <style>

        .coisas{

            border:solid;
            border-width:10px;
            background-color:aqua;
        }


    </style>
    
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Templates</h1>


        <table>
            <tr>
                <td>
                    <asp:FileUpload ID="FileUpload_templates" Width="500px" runat="server" accept=".docx" />
                </td>

                <td>

                    <asp:Button ID="Button_UPLOAD" runat="server" Width="150px"  Text="Upload New Template" OnClick="Button_UPLOAD_Click" />
                </td>
            </tr>

        </table>
    </div>
  
   
    <asp:Button ID="ClientButton" runat="server" Text="Launch Modal Popup (Client)" />
    <asp:Panel ID="ModalPanel" runat="server" Width="500px" CssClass="coisas">
 ASP.NET AJAX is a free framework for quickly creating a new generation of more 
 efficient, more interactive and highly-personalized Web experiences that work 
 across all the most popular browsers.<br />
 <asp:Button ID="OKButton" runat="server" Text="Close" />
</asp:Panel>
    
   
        <ajaxToolkit:ModalPopupExtender ID="mpe" runat="server" TargetControlId="ClientButton" 
        PopupControlID="ModalPanel" OkControlID="OKButton" />

    <asp:ScriptManager ID="asm" runat="server" />

    </form>    

</body>
</html>
