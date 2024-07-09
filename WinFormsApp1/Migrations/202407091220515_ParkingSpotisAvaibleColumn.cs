namespace ParkWay.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ParkingSpotisAvaibleColumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ParkingSpots", "Vehicle", c => c.String());
            AddColumn("dbo.ParkingSpots", "isAvaible", c => c.Boolean(nullable: false));
            AddColumn("dbo.Purchases", "Amount", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Purchases", "Amount");
            DropColumn("dbo.ParkingSpots", "isAvaible");
            DropColumn("dbo.ParkingSpots", "Vehicle");
        }
    }
}
