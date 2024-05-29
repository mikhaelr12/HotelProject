namespace Hotel.BusinessLogic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BDBTables",
                c => new
                    {
                        BookingId = c.Int(nullable: false, identity: true),
                        CheckInDate = c.DateTime(nullable: false),
                        CheckOutDate = c.DateTime(nullable: false),
                        FinalPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Room_Id = c.Int(),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.BookingId)
                .ForeignKey("dbo.RDBTables", t => t.Room_Id)
                .ForeignKey("dbo.UDBTables", t => t.User_Id)
                .Index(t => t.Room_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.RDBTables",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RoomType = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UDBTables",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        LastIp = c.String(),
                        Role = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Sessions",
                c => new
                    {
                        SessionId = c.Int(nullable: false, identity: true),
                        Username = c.String(nullable: false, maxLength: 30),
                        CookieString = c.String(nullable: false),
                        ExpireTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.SessionId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BDBTables", "User_Id", "dbo.UDBTables");
            DropForeignKey("dbo.BDBTables", "Room_Id", "dbo.RDBTables");
            DropIndex("dbo.BDBTables", new[] { "User_Id" });
            DropIndex("dbo.BDBTables", new[] { "Room_Id" });
            DropTable("dbo.Sessions");
            DropTable("dbo.UDBTables");
            DropTable("dbo.RDBTables");
            DropTable("dbo.BDBTables");
        }
    }
}
