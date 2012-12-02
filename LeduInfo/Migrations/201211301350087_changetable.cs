namespace LeduInfo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changetable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Districts",
                c => new
                    {
                        DistrictID = c.Int(nullable: false, identity: true),
                        DistructName = c.String(),
                    })
                .PrimaryKey(t => t.DistrictID);
            
            AddForeignKey("dbo.HouseInfoes", "houseStyleID", "dbo.HouseStyles", "houseStyleID", cascadeDelete: true);
            CreateIndex("dbo.HouseInfoes", "houseStyleID");
        }
        
        public override void Down()
        {
            DropIndex("dbo.HouseInfoes", new[] { "houseStyleID" });
            DropForeignKey("dbo.HouseInfoes", "houseStyleID", "dbo.HouseStyles");
            DropTable("dbo.Districts");
        }
    }
}
