namespace TrainHard.WebShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.OrderRows", "Orders_Id", c => c.Int());
            AddColumn("dbo.OrderRows", "Products_Id", c => c.Int());
            CreateIndex("dbo.OrderRows", "Orders_Id");
            CreateIndex("dbo.OrderRows", "Products_Id");
            AddForeignKey("dbo.OrderRows", "Orders_Id", "dbo.Orders", "Id");
            AddForeignKey("dbo.OrderRows", "Products_Id", "dbo.Products", "Id");
            DropColumn("dbo.OrderRows", "OrderId");
            DropColumn("dbo.OrderRows", "ProductID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.OrderRows", "ProductID", c => c.Int(nullable: false));
            AddColumn("dbo.OrderRows", "OrderId", c => c.Int(nullable: false));
            DropForeignKey("dbo.OrderRows", "Products_Id", "dbo.Products");
            DropForeignKey("dbo.OrderRows", "Orders_Id", "dbo.Orders");
            DropIndex("dbo.OrderRows", new[] { "Products_Id" });
            DropIndex("dbo.OrderRows", new[] { "Orders_Id" });
            DropColumn("dbo.OrderRows", "Products_Id");
            DropColumn("dbo.OrderRows", "Orders_Id");
        }
    }
}
