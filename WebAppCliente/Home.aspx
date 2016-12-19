<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="WebAppCliente.Home" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server" >
   
    <link href="StyleSheetHome.css" rel="stylesheet" type="text/css">

    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>

    
    <div id="carousel-example-generic" class="carousel slide" data-ride="carousel">
  <!-- Indicators -->
  <ol class="carousel-indicators">
    <li data-target="#carousel-example-generic" data-slide-to="0" class="active"></li>
    <li data-target="#carousel-example-generic" data-slide-to="1"></li>
    <li data-target="#carousel-example-generic" data-slide-to="2"></li>
  </ol>

  <!-- Wrapper for slides -->
  <div class="carousel-inner" role="listbox">
    <div class="item active">
      <img src="Carousel/barcelos.jpg" alt="...">
      <div class="carousel-caption">
        
      </div>
    </div>
    <div class="item">
      <img src="Carousel/festas_viana.jpg" alt="...">
      <div class="carousel-caption">
      
      </div>
    </div>
       <div class="item">
      <img src="Carousel/logo blog iten.jpg" alt="...">
      <div class="carousel-caption">
       
      </div>
    </div>
    Dummy images
  </div>

  <!-- Controls -->
  <a class="left carousel-control" href="#carousel-example-generic" role="button" data-slide="prev">
    <span class="glyphicon glyphicon-chevron-left" aria-hidden="true"></span>
    <span class="sr-only">Previous</span>
  </a>
  <a class="right carousel-control" href="#carousel-example-generic" role="button" data-slide="next">
    <span class="glyphicon glyphicon-chevron-right" aria-hidden="true"></span>
    <span class="sr-only">Next</span>
  </a>
</div>

    <fieldset style="margin-top:50px;">
        <legend id="legend-text">HISTORY</legend>
        <h5 id ="text_presentation">ITEN Solutions – Information Systems, S.A. is the result of a merger between Prológica and CPCis, two of the largest and most representative Portuguese companies in the technological information sector.
The result of this process provided ITEN Solutions with a strengthened enforcement capacity, along with a history of credibility in the market, thus creating one of the largest companies and a major reference in the information technologies sector in Portugal, with a sophisticated and comprehensive range of services and skills available to its customers.</h5>
    </fieldset>
   
</asp:Content>
