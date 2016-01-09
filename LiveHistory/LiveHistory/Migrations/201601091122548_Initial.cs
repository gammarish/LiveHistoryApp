namespace LiveHistory.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CityModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        City_Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.RouteModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        City_Id = c.Int(nullable: false),
                        Route_Name = c.String(),
                        CityModel_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CityModels", t => t.CityModel_Id)
                .Index(t => t.CityModel_Id);
            
            CreateTable(
                "dbo.PointModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Route_Id = c.Int(nullable: false),
                        lon = c.String(),
                        lat = c.String(),
                        RouteModel_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.RouteModels", t => t.RouteModel_Id)
                .Index(t => t.RouteModel_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RouteModels", "CityModel_Id", "dbo.CityModels");
            DropForeignKey("dbo.PointModels", "RouteModel_Id", "dbo.RouteModels");
            DropIndex("dbo.PointModels", new[] { "RouteModel_Id" });
            DropIndex("dbo.RouteModels", new[] { "CityModel_Id" });
            DropTable("dbo.PointModels");
            DropTable("dbo.RouteModels");
            DropTable("dbo.CityModels");
        }
    }
}
