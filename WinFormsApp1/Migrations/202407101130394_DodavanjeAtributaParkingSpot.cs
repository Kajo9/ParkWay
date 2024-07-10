namespace ParkWay.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DodavanjeAtributaParkingSpot : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ParkingSpots", "FloorName_ID", "dbo.Floors");
            DropIndex("dbo.ParkingSpots", new[] { "FloorName_ID" });
            RenameColumn(table: "dbo.ParkingSpots", name: "FloorName_ID", newName: "FloorId");
            AlterColumn("dbo.ParkingSpots", "FloorId", c => c.Int(nullable: false));
            CreateIndex("dbo.ParkingSpots", "FloorId");
            AddForeignKey("dbo.ParkingSpots", "FloorId", "dbo.Floors", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ParkingSpots", "FloorId", "dbo.Floors");
            DropIndex("dbo.ParkingSpots", new[] { "FloorId" });
            AlterColumn("dbo.ParkingSpots", "FloorId", c => c.Int());
            RenameColumn(table: "dbo.ParkingSpots", name: "FloorId", newName: "FloorName_ID");
            CreateIndex("dbo.ParkingSpots", "FloorName_ID");
            AddForeignKey("dbo.ParkingSpots", "FloorName_ID", "dbo.Floors", "ID");
        }
    }
}
