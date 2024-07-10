namespace ParkWay.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Floors",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FloorName = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.ParkingSpots",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        FloorID = c.Int(nullable: false),
                        isAvaible = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Floors", t => t.FloorID, cascadeDelete: true)
                .Index(t => t.FloorID);
            
            CreateTable(
                "dbo.Invoices",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        InvoiceDate = c.DateTime(nullable: false),
                        ParkingSpot_ID = c.Int(),
                        User_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.ParkingSpots", t => t.ParkingSpot_ID)
                .ForeignKey("dbo.Users", t => t.User_ID)
                .Index(t => t.ParkingSpot_ID)
                .Index(t => t.User_ID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Role = c.String(),
                        Username = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.ParkingOverviews",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ParkingSpotName = c.String(),
                        FloorName = c.String(),
                        isReserved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Purchases",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PurchaseDate = c.DateTime(nullable: false),
                        NumberOfDays = c.Int(nullable: false),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ParkingSpot_ID = c.Int(),
                        User_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.ParkingSpots", t => t.ParkingSpot_ID)
                .ForeignKey("dbo.Users", t => t.User_ID)
                .Index(t => t.ParkingSpot_ID)
                .Index(t => t.User_ID);
            
            CreateTable(
                "dbo.Reservations",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ReservationDate = c.DateTime(nullable: false),
                        NumberOfDays = c.Int(nullable: false),
                        ParkingSpot_ID = c.Int(),
                        User_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.ParkingSpots", t => t.ParkingSpot_ID)
                .ForeignKey("dbo.Users", t => t.User_ID)
                .Index(t => t.ParkingSpot_ID)
                .Index(t => t.User_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reservations", "User_ID", "dbo.Users");
            DropForeignKey("dbo.Reservations", "ParkingSpot_ID", "dbo.ParkingSpots");
            DropForeignKey("dbo.Purchases", "User_ID", "dbo.Users");
            DropForeignKey("dbo.Purchases", "ParkingSpot_ID", "dbo.ParkingSpots");
            DropForeignKey("dbo.Invoices", "User_ID", "dbo.Users");
            DropForeignKey("dbo.Invoices", "ParkingSpot_ID", "dbo.ParkingSpots");
            DropForeignKey("dbo.ParkingSpots", "FloorID", "dbo.Floors");
            DropIndex("dbo.Reservations", new[] { "User_ID" });
            DropIndex("dbo.Reservations", new[] { "ParkingSpot_ID" });
            DropIndex("dbo.Purchases", new[] { "User_ID" });
            DropIndex("dbo.Purchases", new[] { "ParkingSpot_ID" });
            DropIndex("dbo.Invoices", new[] { "User_ID" });
            DropIndex("dbo.Invoices", new[] { "ParkingSpot_ID" });
            DropIndex("dbo.ParkingSpots", new[] { "FloorID" });
            DropTable("dbo.Reservations");
            DropTable("dbo.Purchases");
            DropTable("dbo.ParkingOverviews");
            DropTable("dbo.Users");
            DropTable("dbo.Invoices");
            DropTable("dbo.ParkingSpots");
            DropTable("dbo.Floors");
        }
    }
}
