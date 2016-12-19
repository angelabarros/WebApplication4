<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UploadExcel.aspx.cs" Inherits="WebAppCliente.UploadExcel" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

     <style>
    .align-center {
        display: block;
        margin: 1.0em auto;
        text-align: center;    
    }

    </style>

    
   
    <div class="test_css">
        
    <h1 style="text-align:center;">Upload Excel Templates</h1>
    
    <div style="margin-top:50px;" >
        <fieldset  class="align-center">

        <legend style="font-size:26px;">Upload</legend>
    
        <table class="align-center" style="width:300px;">
            <tr>
                <td style="width:200px;">
                   <asp:FileUpload class="align-center" ID = "FileUpload1"  runat = "server" style="width:200px;"  /> 
                </td>
                <td style="width:100px;">
                    <asp:Button ID = "Button1"  runat = "server"  Text = "Load Excel"  style="height:23px;" OnClick = "Button1_Click" /> 
                </td>
            </tr>


        </table>
     
        

    </fieldset>
    </div>

    </div>


    

    


</asp:Content>
