<%@ Page Title="Generator" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Generator.aspx.cs" Inherits="WebApp.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %></h2>

    
    <div> 

        <p/>  <asp:Image ID="Imagebanner"  runat="server" Height="16px" Width="737px" />

        
        <p/>  

        <p>
            <asp:Label ID="Label_name" runat="server" Text="Client's Name:"></asp:Label>
            <asp:TextBox ID="TB_clientName" runat="server" Width="273px"></asp:TextBox>
        </p>

        <p>
            <asp:Label ID="Label_location" runat="server" Text="Location:"></asp:Label>
            <asp:TextBox ID="TB_location" runat="server" Width="273px"></asp:TextBox>
        </p>

         <p>
            <asp:Label ID="Label_Date" runat="server" Text="Date:"></asp:Label>
            <asp:TextBox ID="TB_date" runat="server" Width="273px"></asp:TextBox>
        </p>

         <p>
            <asp:Label ID="Label_Domain" runat="server" Text="Domain:"></asp:Label>
            <asp:TextBox ID="TB_Domain" runat="server" Width="273px"></asp:TextBox>
        </p>

         <p>
            <asp:Label ID="Label_NameContactCompany1" runat="server" Text="Company's Contact Name (Person 1):"></asp:Label>
            <asp:TextBox ID="TB_NameContactCompany1" runat="server" Width="273px"></asp:TextBox>
        </p>

         <p>
            <asp:Label ID="Label_TeleContactCompany1" runat="server" Text="Telephone (Person 1):"></asp:Label>
            <asp:TextBox ID="TB_TeleContactCompany1" runat="server" Width="273px"></asp:TextBox>
        </p>

         <p>
            <asp:Label ID="Label_EmailContact1" runat="server" Text="Email (Person 1):"></asp:Label>
            <asp:TextBox ID="TB_EmailContact1" runat="server" Width="273px"></asp:TextBox>
        </p>

         <p>
            <asp:Label ID="Label_NameContactCompany2" runat="server" Text="Company's Contact Name (Person 2):"></asp:Label>
            <asp:TextBox ID="TB_NameContactCompany2" runat="server" Width="273px"></asp:TextBox>
        </p>
        
         <p>
            <asp:Label ID="Label_TeleContactCompany2" runat="server" Text="Telephone (Person 2):"></asp:Label>
            <asp:TextBox ID="TB_TeleContactCompany2" runat="server" Width="273px"></asp:TextBox>
        </p>

         <p>
            <asp:Label ID="Label_EmailContact2" runat="server" Text="Email (Person 2):"></asp:Label>
            <asp:TextBox ID="TB_EmailContact2" runat="server" Width="273px"></asp:TextBox>
        </p>


    </div>
    
    

</asp:Content>
