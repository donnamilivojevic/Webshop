<%@ Page Title="Kontakta oss" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="TrainHard.WebShop.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
  <center> <h2><%: Title %>.</h2>
    <h3>Your contact page.</h3>
    <address>
   <h4>Telefon: 08-585567 </h4>     
        
        
        <br />
        Öppettider för att ringa vid direkt kundtjänst är:
        <br />
        <abbr title="Phone"></abbr>
        Måndag-Fredag 08:00-16:00 <br />
        Lördag 10:00-15:00 <br />
        Söndag Stängt
        
    </address>

    <address> <%--mailto gör att man kan skicka öppna ett mail som skickas till mail namnet som finns--%>
        <strong>Support:</strong>   <a href="mailto:shofia92@hotmail.com">Support@TrainHard.com</a><br />
        <strong>Marketing:</strong> <a href="mailto:shofia.sharepoint@gmail.com">TrainHard@Marketing.com</a>
    </address></center> 
</asp:Content>
