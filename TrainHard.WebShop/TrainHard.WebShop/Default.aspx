<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TrainHard.WebShop._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <script type="text/javascript" src="Scripts/slick.js"></script>

    <script type="text/javascript">
        $(document).ready(function () {
            $('.SlideShow').slick({
                slidesToShow: 1,
                slidesToScroll: 1,
                autoplay: true,
                autoplaySpeed: 2000,
            });
        });
    </script>

    <link href="Content/slick.css" rel="stylesheet" />
    <link rel="stylesheet" type="text/css" href="Content/slick-theme.css" />


    <div id="Box">
        <div class="SlideShow">
            <div class="productSlider">
                <img id="image1" src="Pictures/Slide/trainhardslide2.jpg" /></div> <%--Länkarna till bilder som skall finnas med i sliden. Lagda i en div. --%>
            <div class="productSlider"><a href="ProductDetails.aspx?productId=22">
                <img id="image3" src="Pictures/Nutrition/wheygold-edit.jpg" /></a></div>
            <div class="productSlider"><a href="ProductDetails.aspx?productId=1">
                <img id="image4" src="Pictures/Slide/herrskor.slide.jpg" /></a></div>
            <div class="productSlider">
                <img id="image5" src="Pictures/Slide/gym-clothes-slide4.jpg" /></div>
        </div>

            <div id="TrainHardTitle">Välkommen till Train Hard!</div> <%--Titeln i en div --%>
         <br />
            <div id="WelcomeText" class="col-md-12">
             Alla har olika mål med sin träning. För vissa handlar det om ett generellt välmående, andra vill bygga muskler eller fokusera på att gå ner i vikt. 
             Oavsett vilka mål du har med din träning behöver du tillsätta kroppen rätt näring och tillskott innan, under samt efter träningspasset. 
             Träna rätt och se till att kroppen får rätt kosttillskott i förhållande till vad du vill uppnå. Train Hard har samlat ett brett utbud av tillskott online.
             Ta gärna hjälp av våra <a id="Bloggar" href="inspiration.aspx">bloggar</a> och <a id="Recept" href="recept.aspx">recept</a> för att få mer information och inspiration för att uppnå dina mål.
         </div> <%-- Texten på startpage innei en div. Länkarna innehåller id för att vara kapabla att koppla med Css. --%>
   </div>      


        <div class="clearfix"></div> 
</asp:Content>
