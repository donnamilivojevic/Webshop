namespace TrainHard.WebShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedDuplicates : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Products", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "Name", c => c.String());
        }
    }
}
