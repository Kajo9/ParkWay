namespace ParkWay.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PromjenaAtributaParkingSpot : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.ParkingSpots", new[] { "Floor_ID" });
            CreateIndex("dbo.ParkingSpots", "floor_ID");
        }
        
        public override void Down()
        {
            DropIndex("dbo.ParkingSpots", new[] { "floor_ID" });
            CreateIndex("dbo.ParkingSpots", "Floor_ID");
        }
    }
}
