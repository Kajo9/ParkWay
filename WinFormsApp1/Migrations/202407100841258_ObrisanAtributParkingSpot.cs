namespace ParkWay.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ObrisanAtributParkingSpot : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.ParkingSpots", "Vehicle");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ParkingSpots", "Vehicle", c => c.String());
        }
    }
}
