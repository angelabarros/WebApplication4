<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MenuFormulas.aspx.cs" Inherits="WebAppCliente.MenuFormulas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <style>
        .title{
            font-size:40px;
            text-align:center;
        }



    </style>



    <h1 class="title">Manage Formulas</h1>

     <fieldset class="field_set" style="background-color:#FCDA00; margin-top:50px;">
              
                 
         <asp:Button class="btn_backoffice" ID="Button1" runat="server" Text="Upload Excel Template" style="margin-left:200px; margin-top:70px; margin-bottom:70px"  Width="300px"  Height ="200px" OnClick="Button1_Click"/>
         <asp:Button class="btn_backoffice" ID="Button2" runat="server" Text="New Formula" style="margin-left:100px; margin-top:70px; margin-bottom:70px"  Width="300px"  Height ="200px" OnClick="Button2_Click" /> 
              
           </fieldset>

</asp:Content>
