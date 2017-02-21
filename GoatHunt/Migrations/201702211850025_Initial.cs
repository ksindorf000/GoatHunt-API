namespace GoatHunt.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Hunts",
                c => new
                    {
                        HuntNumber = c.Int(nullable: false, identity: true),
                        HuntName = c.String(),
                        Type = c.String(),
                        Permits = c.String(),
                        NumHuntersAfield = c.String(),
                        Harvest = c.String(),
                        AverageDays = c.String(),
                        PercentSuccess = c.String(),
                    })
                .PrimaryKey(t => t.HuntNumber);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Hunts");
        }
    }
}
