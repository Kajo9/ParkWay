namespace ParkWay.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PromjenaAtributaParkingSpot1 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.ParkingSpots", name: "floor_ID", newName: "Floor_ID_ID");
            RenameIndex(table: "dbo.ParkingSpots", name: "IX_floor_ID", newName: "IX_Floor_ID_ID");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.ParkingSpots", name: "IX_Floor_ID_ID", newName: "IX_floor_ID");
            RenameColumn(table: "dbo.ParkingSpots", name: "Floor_ID_ID", newName: "floor_ID");
        }
    }
}
