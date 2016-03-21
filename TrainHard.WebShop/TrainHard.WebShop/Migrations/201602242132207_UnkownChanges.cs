namespace TrainHard.WebShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UnkownChanges : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.OrderRows", name: "Orders_Id", newName: "Order_Id");
            RenameColumn(table: "dbo.OrderRows", name: "Products_Id", newName: "Product_Id");
            RenameIndex(table: "dbo.OrderRows", name: "IX_Orders_Id", newName: "IX_Order_Id");
            RenameIndex(table: "dbo.OrderRows", name: "IX_Products_Id", newName: "IX_Product_Id");
            AddColumn("dbo.Products", "Name", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "Name");
            RenameIndex(table: "dbo.OrderRows", name: "IX_Product_Id", newName: "IX_Products_Id");
            RenameIndex(table: "dbo.OrderRows", name: "IX_Order_Id", newName: "IX_Orders_Id");
            RenameColumn(table: "dbo.OrderRows", name: "Product_Id", newName: "Products_Id");
            RenameColumn(table: "dbo.OrderRows", name: "Order_Id", newName: "Orders_Id");
        }
    }
}
