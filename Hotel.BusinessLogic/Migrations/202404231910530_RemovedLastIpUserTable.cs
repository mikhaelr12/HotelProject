namespace Hotel.BusinessLogic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedLastIpUserTable : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.UDBTables", "LastIp");
        }
        
        public override void Down()
        {
            AddColumn("dbo.UDBTables", "LastIp", c => c.String());
        }
    }
}
