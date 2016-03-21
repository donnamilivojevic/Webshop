<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="News.aspx.cs" Inherits="TrainHard.WebShop.News" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<p>Vill du få hem nyhetsbrev? <br />
Där ingår det senaste vi fått in, goda & nyttiga recepter och där vi även har medlemsskaps rabbater!<br />
skriv din mail så får du nyhetsbrev</p>
    <%--klass knapp där du kan skriva ditt mail och när man trycker på knappen försvinner texten på rutan--%>
    <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"></asp:TextBox>
    
<asp:Button ID="Button1" runat="server" Text="Skicka" OnClick ="Button1_Click" />


</asp:Content>
