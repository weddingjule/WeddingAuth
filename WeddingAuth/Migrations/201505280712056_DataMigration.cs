namespace WeddingAuth.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Expenses",
                c => new
                    {
                        ExpenseID = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false),
                        price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ExpenseID);
            
            AddColumn("dbo.AspNetUsers", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Price");
            DropTable("dbo.Expenses");
        }
    }
}
