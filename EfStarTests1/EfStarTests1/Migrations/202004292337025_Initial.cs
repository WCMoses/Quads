namespace EfStarTests1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Regions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MinRa = c.Double(nullable: false),
                        MaxRa = c.Double(nullable: false),
                        MinDec = c.Double(nullable: false),
                        MaxDec = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.Stars",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    RaHours = c.Double(nullable: false),
                    RaMinutes = c.Double(nullable: false),
                    RaSeconds = c.Double(nullable: false),
                    DecimalRa = c.Double(nullable: false),
                    DecDegrees = c.Double(nullable: false),
                    DecMinutes = c.Double(nullable: false),
                    DecSeconds = c.Double(nullable: false),
                    DecimalDec = c.Double(nullable: false),
                    Magnitude = c.Double(nullable: false),
                    Brightness = c.Double(nullable: false),
                    Region = c.Int(nullable: false),
                    Region_Id = c.Int(),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Regions", t => t.Region_Id)
                .Index(t => t.Region_Id);

        }

        public override void Down()
        {
            DropForeignKey("dbo.Stars", "Region_Id", "dbo.Regions");
            DropIndex("dbo.Stars", new[] { "Region_Id" });
            DropTable("dbo.Stars");
            DropTable("dbo.Regions");
        }
    }
}
