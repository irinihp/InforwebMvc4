
namespace LeduInfo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ImgResources", "houseID", c => c.Int(nullable: false));
            AddColumn("dbo.ImgResources", "houseStyleID", c => c.Int(nullable: false));
            AddForeignKey("dbo.ImgResources", "houseID", "dbo.HouseInfoes", "houseID", cascadeDelete: true);
            AddForeignKey("dbo.ImgResources", "houseStyleID", "dbo.HouseStyles", "houseStyleID", cascadeDelete: true);
            CreateIndex("dbo.ImgResources", "houseID");
            CreateIndex("dbo.ImgResources", "houseStyleID");
        }
        
        public override void Down()
        {
            DropIndex("dbo.ImgResources", new[] { "houseStyleID" });
            DropIndex("dbo.ImgResources", new[] { "houseID" });
            DropForeignKey("dbo.ImgResources", "houseStyleID", "dbo.HouseStyles");
            DropForeignKey("dbo.ImgResources", "houseID", "dbo.HouseInfoes");
            DropColumn("dbo.ImgResources", "houseStyleID");
            DropColumn("dbo.ImgResources", "houseID");
        }
    }
}
