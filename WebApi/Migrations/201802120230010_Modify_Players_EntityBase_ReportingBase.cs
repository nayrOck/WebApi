namespace WebApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Modify_Players_EntityBase_ReportingBase : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.GameEvents", "CreatedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.GameEvents", "UpdatedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Games", "CreatedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Games", "UpdatedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Teams", "CreatedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Teams", "UpdatedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Players", "CreatedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Players", "UpdatedDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Players", "UpdatedDate");
            DropColumn("dbo.Players", "CreatedDate");
            DropColumn("dbo.Teams", "UpdatedDate");
            DropColumn("dbo.Teams", "CreatedDate");
            DropColumn("dbo.Games", "UpdatedDate");
            DropColumn("dbo.Games", "CreatedDate");
            DropColumn("dbo.GameEvents", "UpdatedDate");
            DropColumn("dbo.GameEvents", "CreatedDate");
        }
    }
}
