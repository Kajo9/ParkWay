namespace ParkWay.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PromjenaAtributaParkingSpot2 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.ParkingSpots", name: "Floor_ID_ID", newName: "FloorName_ID");
            RenameIndex(table: "dbo.ParkingSpots", name: "IX_Floor_ID_ID", newName: "IX_FloorName_ID");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.ParkingSpots", name: "IX_FloorName_ID", newName: "IX_Floor_ID_ID");
            RenameColumn(table: "dbo.ParkingSpots", name: "FloorName_ID", newName: "Floor_ID_ID");
        }
    }
}
