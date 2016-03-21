namespace TrainHard.WebShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "ProductDescription", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "ProductDescription");
        }
    }
}
