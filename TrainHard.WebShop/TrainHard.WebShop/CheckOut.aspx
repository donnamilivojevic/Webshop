<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CheckOut.aspx.cs" Inherits="TrainHard.WebShop.CheckOut" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <%--En databunden listkontroll som tillåter egen gjord layout genom att repetera en specifik template för varje objekt som visas i listan--%>
    <asp:Repeater ID="chosenProductsRepeater" runat="server">
        <ItemTemplate>
        </ItemTemplate>
    </asp:Repeater>

    <%--En kontroll för att visa text på web sidan --%>
    <div id="KundBox"> 
        <asp:Label ID="totalPrice" runat="server"></asp:Label>
        Customer name:
        <asp:TextBox ID="CustomerName" runat="server" placeholder="Name" CssClass="form-control"></asp:TextBox><p></p> 
        Contact name:                                                                      
        <asp:TextBox ID="ContactName" runat="server" placeholder="Name" CssClass="form-control"></asp:TextBox><p></p>
         Address:                                                                       
        <asp:TextBox ID="Address" runat="server" placeholder="Address" CssClass="form-control"></asp:TextBox><p></p>
        City:
        <asp:TextBox ID="City" runat="server" placeholder="City" CssClass="form-control"></asp:TextBox><p></p>
        Postalcode:
        <asp:TextBox ID="PostalCode" runat="server" placeholder="Postalcode" CssClass="form-control"></asp:TextBox><p></p>
        Country:
        <asp:TextBox ID="Country" runat="server" placeholder="Country" CssClass="form-control"></asp:TextBox><p></p>
        Mail:
        <asp:TextBox ID="Mail" runat="server" placeholder="Mail" CssClass="form-control"></asp:TextBox><p></p>
       
        <%--En knapp kontroll som sänder en vidare till en ny url sida --%>
        <asp:Button ID="Placeorder" runat="server" Text="Köp" OnClick="Placeorder_Click" CssClass="btn-default btn"/>
        <asp:Label ID="Status" runat="server"></asp:Label>

    </div>
</asp:Content>
