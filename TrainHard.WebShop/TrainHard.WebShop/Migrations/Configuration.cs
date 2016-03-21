namespace TrainHard.WebShop.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Models;

    internal sealed class Configuration : DbMigrationsConfiguration<TrainHard.WebShop.Contexts.TrainHard>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TrainHard.WebShop.Contexts.TrainHard context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.

            context.Categories.AddOrUpdate(
                c => c.Name,
                new Category { Name = "Dam" },
                new Category { Name = "Herr" },
                new Category { Name = "Proteinpulver" },
                new Category { Name = "Bars" },
                new Category { Name = "Aminosyror" }
                );
            context.SaveChanges();

            context.Products.AddOrUpdate(
                p => p.ProductName,
                new Product { ProductName = "Under Armour navy blue & white", ProductDescription = "Track byxor med hållbar trikå med en borstad tillbaka, vilket ger en mjuk känsla och överlägsen värme.", ProductPrice = "700", ProductSize = "36, 37, 38, 39, 40, 41, 42, 43, 44", Category = context.Categories.FirstOrDefault(c => c.Name == "Herr"), Image ="/Pictures/Clothing/underarmourbyxorherr.EDIT.png" },
                new Product { ProductName = "Nike PerformanceREAX LIGHTSPEED - Aerobics-& gympaskor-black/metallic/dark grey/anthracite", ProductDescription = "Innersula: textil, Funktion: 30°C maskintvätt", ProductPrice = "999", ProductSize = "36, 37, 38, 39, 40, 41, 42, 43, 44", Category = context.Categories.FirstOrDefault(c => c.Name == "Herr"), Image = "/Pictures/Clothing/nikeherrskorSVART.EDIT.jpg" },
                new Product { ProductName = "Fila METRIQUE II - Aerobics- & gympaskor - black", ProductDescription = "Innersula: textil, Sport: fitness, Yttermaterial: textil/syntet", ProductPrice = "599", ProductSize = "36, 37, 38, 39, 40, 41, 42, 43, 44", Category = context.Categories.FirstOrDefault(c => c.Name == "Herr"), Image = "/Pictures/Clothing/herrskorfilasvart.EDIT.jpg" },
                new Product { ProductName = "Nike black & gold", ProductDescription = "Tryckt grafik, 100% bomull", ProductPrice = "299", ProductSize = "XS, S, M, L, XL, XXL", Category = context.Categories.FirstOrDefault(c => c.Name == "Herr"), Image = "/Pictures/Clothing/nikeherrtshirt.EDIT.png" },
                new Product { ProductName = "Adidas Chicago Bulls", ProductDescription = "100% bomull, Lätt räfflad T-shirt, Officiellt licensierade NBA produkt", ProductPrice = "250", ProductSize = "XS, S, M, L, XL, XXL", Category = context.Categories.FirstOrDefault(c => c.Name == "Herr"), Image = "/Pictures/Clothing/chicagobullsherrtshirt.EDIT.jpg" },
                new Product { ProductName = "Jordan Air Navy blue", ProductDescription = "Läder och syntetmaterial , Sido ventiler", ProductPrice = "399", ProductSize = "XS, S, M, L, XL, XXL", Category = context.Categories.FirstOrDefault(c => c.Name == "Herr"), Image = "/Pictures/Clothing/jordanherrtshirt.EDIT.jpg" },
                new Product { ProductName = "Adidas pants 2 in 1", ProductDescription =  "Sidofickor med dragkedja, Ribbade greninfällningar, Figurnära passform", ProductPrice = "1550", ProductSize = "XS, S, M, L, XL, XXL", Category = context.Categories.FirstOrDefault(c => c.Name == "Herr"), Image = "/Pictures/Clothing/AdidasHerr2i1byxor.jpgEDIT.jpg" },
                new Product { ProductName = "Under Armour training pants", ProductDescription = "Spår byxor med slitstark  trikå med en borstad tillbaka, vilket ger en mjuk känsla och överlägsen värme", ProductPrice = "450", ProductSize = "XS, S, M, L, XL, XXL", Category = context.Categories.FirstOrDefault(c => c.Name == "Herr"), Image = "/Pictures/Clothing/underarmourbyxorherr.EDIT.png" },
                new Product { ProductName = "Adidas black pants white stripes", ProductDescription = "Ventilerade ClimaCool® håller dig sval och torr, sidofickor med dragkedja; Dragsko på resår i midjan", ProductPrice = "399", ProductSize = "XS, S, M, L, XL, XXL", Category = context.Categories.FirstOrDefault(c => c.Name == "Herr"), Image = "/Pictures/Clothing/AdidasHerrvitasträck.EDIT.jpg" },
                new Product { ProductName = "The North Face grey pink t-shirt", ProductDescription = "Bekväm, andande T-shirt", ProductPrice = "199", ProductSize = "XS, S, M, L, XL, XXL", Category = context.Categories.FirstOrDefault(c => c.Name == "Dam"), Image = "/Pictures/Clothing/northfacetshirtdam.EDIT.jpg" },
                new Product { ProductName = "Under Armour pink loongsleve", ProductDescription = "Mjuk, otroligt  lätt konstruktion ger fantastisk täckning utan att tynga ner dig", ProductPrice = "450", ProductSize = "XS, S, M, L, XL, XXL", Category = context.Categories.FirstOrDefault(c => c.Name == "Dam"), Image = "/Pictures/Clothing/tröjarosaunderarmourdam.EDIT.png" },
                new Product { ProductName = "Nike black loongsleve", ProductDescription = "Nike Pro Långärmad V-hals kvinnors Top har en smickrande v-ringning", ProductPrice = "340", ProductSize = "XS, S, M, L, XL, XXL", Category = context.Categories.FirstOrDefault(c => c.Name == "Dam"), Image = "/Pictures/Clothing/nikesvartdamtröja.EDIT.jpg" },
                new Product { ProductName = "Adidas thights black with orange stripes", ProductDescription = "Climalite® tyg sveper bort svett från huden, Inbyggd passform", ProductPrice = "399", ProductSize = "XS, S, M,  L, XL, XXL", Category = context.Categories.FirstOrDefault(c => c.Name == "Dam"), Image = "/Pictures/Clothing/adidassvartröddam.EDIT.jpg" },
                new Product { ProductName = "Nike Performance PRO COOL Tights obsidian/white", ProductDescription = "Passform: tight, Teknologi: Dri-Fit (Nike), Skötselråd: 30°C maskintvätt", ProductPrice = "299", ProductSize = "XS, S, M, L, XL, XXL", Category = context.Categories.FirstOrDefault(c => c.Name == "Dam"), Image = "/Pictures/Clothing/NikePerformancemarinblådam.EDIT.jpg" },
                new Product { ProductName = "Adidas Performers black & white stripes", ProductDescription = "Andningsaktiv: ja, Teknologi: Dri-Fit (Nike), Tvättråd: 30°C maskintvätt", ProductPrice = "350", ProductSize = "XS, S, M, L, XL, XXL", Category = context.Categories.FirstOrDefault(c => c.Name == "Dam"), Image = "/Pictures/Clothing/adidasPerformancevitaränderdam.EDIT.jpg" },
                new Product { ProductName = "Reebok yourflex trainette 8.0 electric peach white", ProductDescription = "Funktion: 30°C maskintvätt", ProductPrice = "599", ProductSize = "35, 36, 37, 38, 39, 40, 41, 42", Category = context.Categories.FirstOrDefault(c => c.Name == "Dam"), Image = "/Pictures/Clothing/reebokdamskor.EDIT.jpg" },
                new Product { ProductName = "Nike Performance flex run 2015 chalk blue white hyper, orange varsity", ProductDescription = "Andas, lätta midfoot stöd och asymmetriska designen där alla arbeta tillsammans", ProductPrice = "1200", ProductSize = "35, 36, 37, 38, 39, 40, 41, 42", Category = context.Categories.FirstOrDefault(c => c.Name == "Dam"), Image = "/Pictures/Clothing/nikedamlöparskorchalkbluewhite.EDIT.jpg" },
                new Product { ProductName = "Under Armour micro g limitless black and white", ProductDescription = "Funktion: 30°C maskintvätt, Sport: fitness, Yttermaterial: skinn och textil", ProductPrice = "599", ProductSize = "35, 36, 37, 38, 39, 40, 41, 42", Category = context.Categories.FirstOrDefault(c => c.Name == "Dam"), Image = "/Pictures/Clothing/underarmourdamskorsvart.EDIT.jpg" },
                new Product { ProductName = "Soy-Pro", ProductDescription = "Star Nutritions Soy-Pro är ett vegetabiliskt proteinpulver baserat på näringsrika sojabönor.", ProductPrice = "350", ProductSize = "250", Category = context.Categories.FirstOrDefault(c => c.Name == "Proteinpulver"), Image = "/Pictures/Nutrition/soy-pro.jpg" },
                new Product { ProductName = "Sojavit", ProductDescription = "Sojavit är ett vegetabiliskt protein med protein från enbart sojabönor.", ProductPrice = "450", ProductSize = "250", Category = context.Categories.FirstOrDefault(c => c.Name == "Proteinpulver"), Image = "/Pictures/Nutrition/sojavit.jpg" },
                new Product { ProductName = "Whey-100", ProductDescription = "Star Nutrition Whey-100 är ett kompromisslöst kvalitetsprotein tillverkat för dig som kräver det bästa, maximal muskeluppbyggnad och fettförbränning!", ProductPrice = "600", ProductSize = "250", Category = context.Categories.FirstOrDefault(c => c.Name == "Proteinpulver"), Image = "/Pictures/Nutrition/whey-100.jpg" },
                new Product { ProductName = "100% Whey Gold", ProductDescription = "100% Whey Gold Standard är världens mest sålda och följaktligen världens mest populära proteinpulver!", ProductPrice = "550", ProductSize = "250", Category = context.Categories.FirstOrDefault(c => c.Name == "Proteinpulver"), Image = "/Pictures/Nutrition/wheeeeeey100.jpg" },
                new Product { ProductName = "BCAA Hardcore", ProductDescription = "BCAA Hardcore från Chained Nutrition innehåller grenade aminosyror i fri form och extratillsatt L-Glutamin.", ProductPrice = "250", ProductSize = "500", Category = context.Categories.FirstOrDefault(c => c.Name == "Aminosyror"), Image = "/Pictures/Nutrition/bcaa hardcore.jpg" },
                new Product { ProductName = "BCAA Flash", ProductDescription = "BCAA Flash från Biotech - Med aminosyrorna L-valin, L-Leucin och L-isoleucin.", ProductPrice = "200", ProductSize = "500", Category = context.Categories.FirstOrDefault(c => c.Name == "Aminosyror"), Image = "/Pictures/Nutrition/bcaa flash.jpg" },
                new Product { ProductName = "EAA", ProductDescription = "Star Nutritions EAA, som stimulerar muskeltillväxten och hämmar muskelnedbrytningen!", ProductPrice = "200", ProductSize = "200", Category = context.Categories.FirstOrDefault(c => c.Name == "Aminosyror"), Image = "/Pictures/Nutrition/eaa star nutrition.jpg" },
                new Product { ProductName = "Ultra Amino", ProductDescription = "Ultra Amino från Scitec Nutrtion är ett högkoncentrerat och komplett tillskott av aminosyror från intakt protein. ", ProductPrice = "149", ProductSize = "200", Category = context.Categories.FirstOrDefault(c => c.Name == "Aminosyror"), Image = "/Pictures/Nutrition/eaa ultra amino.jpg" },
                new Product { ProductName = "Natural Energy bar", ProductDescription = "Natural Energy Bar innehåller endast naturliga råvaror som havre och frukt.", ProductPrice = "15", ProductSize = "", Category = context.Categories.FirstOrDefault(c => c.Name == "Bars"), Image = "/Pictures/Nutrition/natural energy bar.jpg" },
                new Product { ProductName = "Maxim Energy bar", ProductDescription = "En krispig energibar med frukt och havre för att maximera din prestation.", ProductPrice = "20", ProductSize = "", Category = context.Categories.FirstOrDefault(c => c.Name == "Bars"), Image = "/Pictures/Nutrition/maxim energy bar.jpg" },
                new Product { ProductName = "Gainomax Protein bar", ProductDescription = "Gainomax Protein Bar - Efterlängtad bar med högt proteininnehåll och grym smak.", ProductPrice = "17", ProductSize = "", Category = context.Categories.FirstOrDefault(c => c.Name == "Bars"), Image = "/Pictures/Nutrition/gainomax protein bar.jpg" },
                new Product { ProductName = "Nutramino Protein bar", ProductDescription = "Extremt god proteinbar från Nutramino, med den fantastiska smaken - Chunky Peanut & Caramel!", ProductPrice = "23", ProductSize = "", Category = context.Categories.FirstOrDefault(c => c.Name == "Bars"), Image = "/Pictures/Nutrition/naturamino protein bar.jpg" }
                );
            context.SaveChanges();

            context.Products.First(p => p.ProductName == "Under Armour navy blue & white").Category = context.Categories.First(c => c.Name == "Herr");
            context.Products.First(p => p.ProductName == "Nike PerformanceREAX LIGHTSPEED - Aerobics-& gympaskor-black/metallic/dark grey/anthracite").Category = context.Categories.First(c => c.Name == "Herr");
            context.Products.First(p => p.ProductName == "Fila METRIQUE II - Aerobics- & gympaskor - black").Category = context.Categories.First(c => c.Name == "Herr");
            context.Products.First(p => p.ProductName == "Nike black & gold").Category = context.Categories.First(c => c.Name == "Herr");
            context.Products.First(p => p.ProductName == "Adidas Chicago Bulls").Category = context.Categories.First(c => c.Name == "Herr");
            context.Products.First(p => p.ProductName == "Jordan Air Navy blue").Category = context.Categories.First(c => c.Name == "Herr");
            context.Products.First(p => p.ProductName == "Adidas pants 2 in 1").Category = context.Categories.First(c => c.Name == "Herr");
            context.Products.First(p => p.ProductName == "Under Armour training pants").Category = context.Categories.First(c => c.Name == "Herr");
            context.Products.First(p => p.ProductName == "Adidas black pants white stripes").Category = context.Categories.First(c => c.Name == "Herr");
            context.Products.First(p => p.ProductName == "The North Face grey pink t-shirt").Category = context.Categories.First(c => c.Name == "Dam");
            context.Products.First(p => p.ProductName == "Under Armour pink loongsleve").Category = context.Categories.First(c => c.Name == "Dam");
            context.Products.First(p => p.ProductName == "Nike black loongsleve").Category = context.Categories.First(c => c.Name == "Dam");
            context.Products.First(p => p.ProductName == "Adidas thights black with orange stripes").Category = context.Categories.First(c => c.Name == "Dam");
            context.Products.First(p => p.ProductName == "Nike Performance PRO COOL Tights obsidian/white").Category = context.Categories.First(c => c.Name == "Dam");
            context.Products.First(p => p.ProductName == "Adidas Performers black & white stripes").Category = context.Categories.First(c => c.Name == "Dam");
            context.Products.First(p => p.ProductName == "Reebok yourflex trainette 8.0 electric peach white").Category = context.Categories.First(c => c.Name == "Dam");
            context.Products.First(p => p.ProductName == "Nike Performance flex run 2015 chalk blue white hyper, orange varsity").Category = context.Categories.First(c => c.Name == "Dam");
            context.Products.First(p => p.ProductName == "Under Armour micro g limitless black and white").Category = context.Categories.First(c => c.Name == "Dam");
            context.Products.First(p => p.ProductName == "Soy-Pro").Category = context.Categories.First(c => c.Name == "Proteinpulver");
            context.Products.First(p => p.ProductName == "Sojavit").Category = context.Categories.First(c => c.Name == "Proteinpulver");
            context.Products.First(p => p.ProductName == "Whey-100").Category = context.Categories.First(c => c.Name == "Proteinpulver");
            context.Products.First(p => p.ProductName == "100% Whey Gold").Category = context.Categories.First(c => c.Name == "Proteinpulver");
            context.Products.First(p => p.ProductName == "BCAA Hardcore").Category = context.Categories.First(c => c.Name == "Aminosyror");
            context.Products.First(p => p.ProductName == "BCAA Flash").Category = context.Categories.First(c => c.Name == "Aminosyror");
            context.Products.First(p => p.ProductName == "EAA").Category = context.Categories.First(c => c.Name == "Aminosyror");
            context.Products.First(p => p.ProductName == "Ultra Amino").Category = context.Categories.First(c => c.Name == "Aminosyror");
            context.Products.First(p => p.ProductName == "Natural Energy bar").Category = context.Categories.First(c => c.Name == "Bars");
            context.Products.First(p => p.ProductName == "Maxim Energy bar").Category = context.Categories.First(c => c.Name == "Bars");
            context.Products.First(p => p.ProductName == "Gainomax Protein bar").Category = context.Categories.First(c => c.Name == "Bars");
            context.Products.First(p => p.ProductName == "Nutramino Protein bar").Category = context.Categories.First(c => c.Name == "Bars");
            context.SaveChanges();

           

            context.Customers.AddOrUpdate(
               p => p.CustomerName,
               new Customer { CustomerName = "Friskis&Svettis", ContactName = "Bengt Gunnarsson", Address = "Kungsgatan 36", PostalCode = "12030", City = "Uppsala", Country = "Sverige", Mail = "bengt.gunnarsson@friskis.se" },
               new Customer { CustomerName = "SATS", ContactName = "Frida Johansson", Address = "St. Eriksgatan 60", PostalCode = "11210", City = "Stockholm", Country = "Sverige", Mail = "frida.johansson@sats.se" },
               new Customer { CustomerName = "Anna Eliasson", ContactName = "Anna Eliasson", Address = "Berggatan 10", PostalCode = "76234", City = "Umeå", Country = "Sverige", Mail = "eliasson@gmail.com" },
               new Customer { CustomerName = "Patrik Svensson ", ContactName = "Patrik Svensson", Address = "Almqvistgatan 40", PostalCode = "90872", City = "Göteborg", Country = "Sverige", Mail = "patriksvensson@hotmail.se" }
                );
            context.SaveChanges();

            context.Orders.AddOrUpdate(
                p => p.Id,
                new Order { Customer = context.Customers.First(), Date = new DateTime(2016, 2, 18), Price = 100 },
                new Order { Customer = context.Customers.First(), Date = new DateTime(2016, 2, 18), Price = 200 },
                new Order { Customer = context.Customers.First(), Date = new DateTime(2016, 2, 18), Price = 300 },
                new Order { Customer = context.Customers.First(), Date = new DateTime(2016, 2, 18), Price = 400 }
                );
            context.SaveChanges();

            context.OrderRows.AddOrUpdate(
                p => p.Id, 
                new OrderRow { Order = context.Orders.First(), Product = context.Products.First(), Quantity = 2 },
                new OrderRow { Order = context.Orders.First(), Product = context.Products.First(), Quantity = 3 },
                new OrderRow { Order = context.Orders.First(), Product = context.Products.First(), Quantity = 4 },
                new OrderRow { Order = context.Orders.First(), Product = context.Products.First(), Quantity = 5 }
                );
            context.SaveChanges();
        }
    }
}
