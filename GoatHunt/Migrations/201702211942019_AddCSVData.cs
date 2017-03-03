namespace GoatHunt.Migrations
{
    using Controllers;
    using Models;
    using System;
    using System.Data.Entity.Migrations;
    using System.IO;

    public partial class AddCSVData : DbMigration
    {
        public override void Up()
        {
            var csvPath = AppDomain.CurrentDomain.BaseDirectory + @"..\App_Data\Data.csv";
            var openFile = File.ReadAllLines(csvPath);

            using (var db = new ApplicationDbContext())
            {
                foreach (string row in openFile)
                {
                    var data = row.Split(',');
                    Hunt newHunt = new Hunt
                    {
                        HuntNumber = data[0],
                        HuntName = data[1],
                        Type = data[2],
                        Permits = data[3],
                        NumHuntersAfield = data[4],
                        Harvest = data[5],
                        AverageDays = data[6],
                        PercentSuccess = data[7]
                    };
                    db.Hunts.Add(newHunt);
                }
                db.SaveChanges();
            }

            //---------------//
            //throw new Exception("no errors");
        }

        public override void Down()
        {
        }
    }
}
