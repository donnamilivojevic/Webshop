namespace TrainHard.WebShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ForcingSeed : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "ProductQuantity", c => c.String());
            AddColumn("dbo.Products", "ProductWeight", c => c.String());
            AlterColumn("dbo.Customers", "Country", c => c.String());
            AlterColumn("dbo.Products", "ProductPrice", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "ProductPrice", c => c.Int(nullable: false));
            AlterColumn("dbo.Customers", "Country", c => c.Int(nullable: false));
            DropColumn("dbo.Products", "ProductWeight");
            DropColumn("dbo.Products", "ProductQuantity");
        }
    }
}
