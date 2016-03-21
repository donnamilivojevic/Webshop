<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="homepage.aspx.cs" Inherits="TrainHard.WebShop.homepage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
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


    <body class="startpage">
        <div id="TopList">
            <div id="ToppTitle">Topp 5</div>
            <ul>
                <li>1. Soy-Pro</li>
                <li>2. 100% Whey Gold</li>
                <li>3. BCAA Hardcore</li>
                <li>4. Gainomax Protein Bar</li>
                <li>5. Ultra Amino</li>
            </ul>
        </div>

        <div id="Box">
            <div class="SlideShow">
                <div class="productSlider">
                    <img id="image1" src="Pictures/Slide/trainhardslide2.jpg" /></div>
                <div class="productSlider"><a href="ProductDetails.aspx?productId=22">
                    <img id="image3" src="Pictures/Nutrition/wheygold-edit.jpg" /></a></div>
                <div class="productSlider"><a href="ProductDetails.aspx?productId=1">
                    <img id="image4" src="Pictures/Clothing/herrskor.slide.jpg" /></a></div>
                <div class="productSlider">
                    <img id="image5" src="Pictures/Clothing/gym-clothes-slide4.jpg" /></div>
            </div>
            <div id="WelcomeText">
                <div id="TrainHardTitle">Välkommen till Train Hard!</div>
                <br />
                <p>
                    Alla har olika mål med sin träning. För vissa handlar det om ett generellt välmående, andra vill bygga muskler eller fokusera på att gå ner i vikt. 
             Oavsett vilka mål du har med din träning behöver du tillsätta kroppen rätt näring och tillskott innan, under samt efter träningspasset. 
             Träna rätt och se till att kroppen får rätt kosttillskott i förhållande till vad du vill uppnå. Train Hard har samlat ett brett utbud av tillskott online.
             Ta gärna hjälp av våra <a id="Bloggar" href="inspiration.aspx">bloggar</a> och <a id="Recept" href="recept.aspx">recept</a> för att få mer information och inspiration för att uppnå dina mål.
                </p>
            </div>
        </div>
    </body>


</asp:Content>
