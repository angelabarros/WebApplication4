<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="BackOffice.aspx.cs" Inherits="WebAppCliente.BackOffice" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
            
    <legend style="text-align:center; margin-top:100px; font-size:40px">Back-Office Tools</legend>
  
             <fieldset class="field_set" style="background-color:#FCDA00">
              
                 
               
                 
               <asp:Button class="btn_backoffice" ID="Button_users" runat="server" Text="Manage Users" style="margin-right:50px; margin-left:100px; margin-top:70px; margin-bottom:40px"  Width="200px" Height ="200px" OnClick="Button_users_Click"/>
               <asp:Button class="btn_backoffice" ID="Button_templates" runat="server" Text="Manage Templates" style="margin-right:50px; margin-top:40px; margin-bottom:70px"  Width="200px"  Height ="200px" OnClick="Button_templates_Click"/>
               <asp:Button class="btn_backoffice" ID="Button_formulas" runat="server" Text="Manage Formulas" style="margin-right:50px; margin-top:40px; margin-bottom:70px"  Width="200px"  Height ="200px" OnClick="Button_formulas_Click"/>
               <asp:Button class="btn_backoffice" ID="Button_Clients" runat="server" Text="Manage Clients" style="margin-right:50px; margin-top:40px; margin-bottom:70px"  Width="200px"  Height ="200px" OnClick="Button_Clients_Click"/>
                
           </fieldset>
      
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        

</asp:Content>
