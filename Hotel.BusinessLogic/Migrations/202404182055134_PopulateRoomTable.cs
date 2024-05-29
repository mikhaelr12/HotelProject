namespace Hotel.BusinessLogic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateRoomTable : DbMigration
    {
		public override void Up()
		{
			Sql("INSERT INTO RDBTables (RoomType, Price) VALUES ('0', 100.00)");
			Sql("INSERT INTO RDBTables (RoomType, Price) VALUES ('1', 200.00)");
			Sql("INSERT INTO RDBTables (RoomType, Price) VALUES ('2', 400.00)");
			Sql("INSERT INTO RDBTables (RoomType, Price) VALUES ('3', 600.00)");
			Sql("INSERT INTO RDBTables (RoomType, Price) VALUES ('4', 800.00)");
			Sql("INSERT INTO RDBTables (RoomType, Price) VALUES ('5', 1000.00)");
		}

		public override void Down()
		{
			Sql("DELETE FROM RDBTables WHERE RoomType = '0'");
			Sql("DELETE FROM RDBTables WHERE RoomType = '1'");
			Sql("DELETE FROM RDBTables WHERE RoomType = '2'");
			Sql("DELETE FROM RDBTables WHERE RoomType = '3'");
			Sql("DELETE FROM RDBTables WHERE RoomType = '4'");
			Sql("DELETE FROM RDBTables WHERE RoomType = '5'");
		}
	}
}
