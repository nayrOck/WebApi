namespace WebApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Added_Account : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.Users", "Account_ID", c => c.Int());
            CreateIndex("dbo.Users", "Account_ID");
            AddForeignKey("dbo.Users", "Account_ID", "dbo.Accounts", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "Account_ID", "dbo.Accounts");
            DropIndex("dbo.Users", new[] { "Account_ID" });
            DropColumn("dbo.Users", "Account_ID");
            DropTable("dbo.Accounts");
        }
    }
}
