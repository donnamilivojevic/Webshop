<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductDetails.aspx.cs" Inherits="TrainHard.WebShop.ProductDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

     <div class="ProPro">
         <%--Söker efter i databasen produkter med värde av produktnamn, produktbild och produkt beskrivning --%>
        <asp:Label ID="productName" runat="server"></asp:Label>
        <asp:Image ID="productImage" runat="server" />
        <asp:Label ID="productDescription" runat="server"> </asp:Label>

         <%--Skapar en dropdown funktion som hämtat information från databasen och sedan skriver ut det i webläsaren--%>
        <asp:DropDownList ID="Sizes" runat="server"></asp:DropDownList> 
        
         <%--Skapar en dropdown funktion som hämtat information från databasen och sedan skriver ut det i webläsaren--%>
         <asp:DropDownList ID="Quantities" runat="server">
             <asp:ListItem Text="0" Value="0"></asp:ListItem>
             <asp:ListItem Text="1" Value="1"></asp:ListItem>
             <asp:ListItem Text="2" Value="2"></asp:ListItem>
             <asp:ListItem Text="3" Value="3"></asp:ListItem>
             <asp:ListItem Text="4" Value="4"></asp:ListItem>
             <asp:ListItem Text="5" Value="5"></asp:ListItem>
         </asp:DropDownList>
        
         <%--Skapar en knapp funktion som är kopplat till onclick metoden.  --%>
         <asp:Button ID="Button1" runat="server" Text="Köp" CssClass="btn btn-default" OnClick="buyButton_Click" /> 
    </div> 
 </asp:Content>



