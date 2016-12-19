<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Templates.aspx.cs" Inherits="WebAppCliente.Templates" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
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
    </form>
</body>
</html>
