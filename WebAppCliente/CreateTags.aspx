<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateTags.aspx.cs" Inherits="WebAppCliente.CreateTags" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1> Create a new Tag</h1>



    </div>
        <asp:Label ID="Label_name" runat="server" Text="Name:"></asp:Label>

        <asp:TextBox ID="TextBox_nameTag" runat="server"></asp:TextBox>
        
        
        <br />
        
        
        <br />
        
        
        <br />
        <asp:Label ID="Label_template" runat="server" Text="Template:"></asp:Label>

        
        
        <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:projetoConnectionString %>" ProviderName="<%$ ConnectionStrings:projetoConnectionString.ProviderName %>" SelectCommand="SELECT [name_template] FROM [template]"></asp:SqlDataSource>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />

        
        
    </form>
</body>
</html>
