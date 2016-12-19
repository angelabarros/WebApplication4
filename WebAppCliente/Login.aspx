<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebAppCliente.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
   
    <link href="StyleSheetLogin.css" rel="stylesheet" type="text/css">
<body>
    <form id="form1" runat="server">
    


        <div style="width: 300px; text-align: center;">
       
            <img class="img-circle" src="/Images/logo-iten.png" />
        
        </div>


        <p>
            <asp:login id="Login1" runat="server" style="width: 100%;">
    <layouttemplate>
        <div class="box">
            <div class="content">
                <h1>
                    Authentication Required</h1>
                <asp:textbox class="field" placeholder="Username" id="UserName" runat="server"></asp:textbox>
                <asp:requiredfieldvalidator id="UserNameRequired" runat="server" controltovalidate="UserName" errormessage="User Name is required." tooltip="User Name is required." validationgroup="Login1"> Username is required</asp:requiredfieldvalidator>
                <br>
                <asp:textbox class="field" placeholder="Password" id="Password" runat="server" textmode="Password"></asp:textbox>
                <asp:requiredfieldvalidator id="PasswordRequired" runat="server" controltovalidate="Password" errormessage="Password is required." tooltip="Password is required." validationgroup="Login1"> Password is required</asp:requiredfieldvalidator>
                <br>
                <asp:button class="btn" id="LoginButton" runat="server" OnClick="ButtonLOGIN_Click" commandname="Login" text="Log In" validationgroup="Login1"></asp:button>
                <br>
                <asp:literal id="FailureText" runat="server" enableviewstate="False"></asp:literal></div>
        </div>
    </layouttemplate>
</asp:login>
        </p>
    </form>

  
</body>
</html>
