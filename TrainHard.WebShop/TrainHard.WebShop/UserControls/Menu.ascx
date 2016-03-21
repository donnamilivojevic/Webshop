<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Menu.ascx.cs" Inherits="TrainHard.WebShop.Menu" %>

<header>
    <div id="Loggan">
        <img src="Pictures/logotyp.png" />
    </div>
</header>

<nav id="meny">
    <ul>
        <li><a href="homepage.aspx">Startsidan</a></li>
        <li><a href="#">Kosttillskott</a>
            <ul>
                <%--En databunden listkontroll som tillåter egen gjord layout genom att repetera en specifik template för varje objekt som visas i listan--%>
                <asp:Repeater ID="nutritionCategories" runat="server">
                    <ItemTemplate>
                        <li>
                            <%--En länk till den egen gjorda layouten där kategori id samt kategori namn visas --%>
                            <a href='Categories.aspx?categoryId=<%#Eval("Id") %>'><%#Eval("Name") %></a> 
                        </li>
                    </ItemTemplate>
                </asp:Repeater>
            </ul>
            <li><a href="#">Träningskläder</a>
                <ul>
                      <%--En databunden listkontroll som tillåter egen gjord layout genom att repetera en specifik template för varje objekt som visas i listan--%>
                    <asp:Repeater ID="clothingCategories" runat="server">
                        <ItemTemplate>
                            <li>
                                 <%--En länk till den egen gjorda layouten där kategori id samt kategori namn visas --%>
                                <a href='Categories.aspx?categoryId=<%#Eval("Id") %>'><%#Eval("Name") %></a>
                            </li>
                        </ItemTemplate>
                    </asp:Repeater>
                </ul>
            </li>
        <li><a href="#">Inspiration</a>
            <ul>
                <li><a href="inspiration.aspx">Träningsbloggar</a></li>
                <li><a href="recept.aspx">Recept</a></li>
            </ul>
        </li>
    </ul>
</nav>