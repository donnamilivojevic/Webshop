namespace TrainHard.WebShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedCusomterToOrder : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "Customer_Id", c => c.Int());
            CreateIndex("dbo.Orders", "Customer_Id");
            AddForeignKey("dbo.Orders", "Customer_Id", "dbo.Customers", "Id");
            DropColumn("dbo.Orders", "CustomerId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Orders", "CustomerId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Orders", "Customer_Id", "dbo.Customers");
            DropIndex("dbo.Orders", new[] { "Customer_Id" });
            DropColumn("dbo.Orders", "Customer_Id");
        }
    }
}
