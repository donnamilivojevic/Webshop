<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ShoppingBasket.ascx.cs" Inherits="TrainHard.WebShop.ShoppingBasket" %>

<div id="Kundkorg">
    <span class="glyphicon glyphicon-shopping-cart classIcon"></span> <%--Definierar en sektion i dokumentet --%>
    <div id="Basket"><%--Definierar en sektionen i dokumentet där kundkorgen kommer vara i --%>
        <asp:Label ID="NumberOfItemsInbasket" runat="server"><%--En kontroll som visar upp text på wen web sida, i detta fall mängden produkter som finns i kundkorgen --%>
        </asp:Label>
    </div>
    <p></p>
    <div id="KundvagnTillKassan">
        <a href="CheckOut.aspx" id="KassanKnapp">Gå till kassan</a><%--Länk till check out sidan som man kommer till om man trycker på gå till kassan knappen--%>
    </div>
</div>
