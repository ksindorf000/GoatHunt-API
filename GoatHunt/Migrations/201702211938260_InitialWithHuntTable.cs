namespace GoatHunt.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialWithHuntTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Hunts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        HuntNumber = c.String(),
                        HuntName = c.String(),
                        Type = c.String(),
                        Permits = c.String(),
                        NumHuntersAfield = c.String(),
                        Harvest = c.String(),
                        AverageDays = c.String(),
                        PercentSuccess = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Hunts");
        }
    }
}
