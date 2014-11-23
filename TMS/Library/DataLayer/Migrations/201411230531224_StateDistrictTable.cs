namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StateDistrictTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.States",
                c => new
                    {
                        StateId = c.Int(nullable: false, identity: true),
                        StateName = c.String(nullable: false, maxLength: 150),
                    })
                .PrimaryKey(t => t.StateId);
            
            CreateTable(
                "dbo.District",
                c => new
                    {
                        DisrictId = c.Int(nullable: false, identity: true),
                        StateId = c.Int(nullable: false),
                        DistrictName = c.String(nullable: false, maxLength: 150),
                    })
                .PrimaryKey(t => t.DisrictId);
            
            AddColumn("dbo.Users", "DistrictId", c => c.Int(nullable: false));
            AddColumn("dbo.Users", "StateId", c => c.Int(nullable: false));
            AddForeignKey("dbo.Users", "StateId", "dbo.States", "StateId", cascadeDelete: true);
            AddForeignKey("dbo.Users", "DistrictId", "dbo.District", "DisrictId", cascadeDelete: true);
            CreateIndex("dbo.Users", "StateId");
            CreateIndex("dbo.Users", "DistrictId");
            DropColumn("dbo.Users", "District");
            DropColumn("dbo.Users", "State");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "State", c => c.Int());
            AddColumn("dbo.Users", "District", c => c.Int());
            DropIndex("dbo.Users", new[] { "DistrictId" });
            DropIndex("dbo.Users", new[] { "StateId" });
            DropForeignKey("dbo.Users", "DistrictId", "dbo.District");
            DropForeignKey("dbo.Users", "StateId", "dbo.States");
            DropColumn("dbo.Users", "StateId");
            DropColumn("dbo.Users", "DistrictId");
            DropTable("dbo.District");
            DropTable("dbo.States");
        }
    }
}
