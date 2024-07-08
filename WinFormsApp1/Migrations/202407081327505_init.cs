namespace ParkWay.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bases",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FloorName = c.String(),
                        InvoiceDate = c.DateTime(),
                        Name = c.String(),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Role = c.String(),
                        Username = c.String(),
                        Password = c.String(),
                        ParkingSpotName = c.String(),
                        FloorName1 = c.String(),
                        isReserved = c.Boolean(),
                        PurchaseDate = c.DateTime(),
                        NumberOfDays = c.Int(),
                        ReservationDate = c.DateTime(),
                        NumberOfDays1 = c.Int(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                        Floor_ID = c.Int(),
                        ParkingSpot_ID = c.Int(),
                        User_ID = c.Int(),
                        ParkingSpot_ID1 = c.Int(),
                        User_ID1 = c.Int(),
                        ParkingSpot_ID2 = c.Int(),
                        User_ID2 = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Bases", t => t.Floor_ID)
                .ForeignKey("dbo.Bases", t => t.ParkingSpot_ID)
                .ForeignKey("dbo.Bases", t => t.User_ID)
                .ForeignKey("dbo.Bases", t => t.ParkingSpot_ID1)
                .ForeignKey("dbo.Bases", t => t.User_ID1)
                .ForeignKey("dbo.Bases", t => t.ParkingSpot_ID2)
                .ForeignKey("dbo.Bases", t => t.User_ID2)
                .Index(t => t.Floor_ID)
                .Index(t => t.ParkingSpot_ID)
                .Index(t => t.User_ID)
                .Index(t => t.ParkingSpot_ID1)
                .Index(t => t.User_ID1)
                .Index(t => t.ParkingSpot_ID2)
                .Index(t => t.User_ID2);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Bases", "User_ID2", "dbo.Bases");
            DropForeignKey("dbo.Bases", "ParkingSpot_ID2", "dbo.Bases");
            DropForeignKey("dbo.Bases", "User_ID1", "dbo.Bases");
            DropForeignKey("dbo.Bases", "ParkingSpot_ID1", "dbo.Bases");
            DropForeignKey("dbo.Bases", "User_ID", "dbo.Bases");
            DropForeignKey("dbo.Bases", "ParkingSpot_ID", "dbo.Bases");
            DropForeignKey("dbo.Bases", "Floor_ID", "dbo.Bases");
            DropIndex("dbo.Bases", new[] { "User_ID2" });
            DropIndex("dbo.Bases", new[] { "ParkingSpot_ID2" });
            DropIndex("dbo.Bases", new[] { "User_ID1" });
            DropIndex("dbo.Bases", new[] { "ParkingSpot_ID1" });
            DropIndex("dbo.Bases", new[] { "User_ID" });
            DropIndex("dbo.Bases", new[] { "ParkingSpot_ID" });
            DropIndex("dbo.Bases", new[] { "Floor_ID" });
            DropTable("dbo.Bases");
        }
    }
}
