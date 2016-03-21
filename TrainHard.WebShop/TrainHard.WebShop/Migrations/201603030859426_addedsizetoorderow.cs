namespace TrainHard.WebShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedsizetoorderow : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.OrderRows", "Size", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.OrderRows", "Size");
        }
    }
}
