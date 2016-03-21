namespace TrainHard.WebShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changedpostalcodetostring : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "PostalCode", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "PostalCode", c => c.Int(nullable: false));
        }
    }
}
