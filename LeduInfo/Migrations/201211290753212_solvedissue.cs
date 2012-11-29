namespace LeduInfo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class solvedissue : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.HouseStyles", "ImgResource_imgID", c => c.Int());
            AddColumn("dbo.ImgResources", "houseID", c => c.Int(nullable: false));
            AddColumn("dbo.ImgResources", "houseStyleID", c => c.Int(nullable: false));
            AddForeignKey("dbo.HouseStyles", "ImgResource_imgID", "dbo.ImgResources", "imgID");
            AddForeignKey("dbo.ImgResources", "houseID", "dbo.HouseInfoes", "houseID", cascadeDelete: true);
            CreateIndex("dbo.HouseStyles", "ImgResource_imgID");
            CreateIndex("dbo.ImgResources", "houseID");
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.ImgResources", new[] { "houseID" });
            DropIndex("dbo.HouseStyles", new[] { "ImgResource_imgID" });
            DropForeignKey("dbo.ImgResources", "houseID", "dbo.HouseInfoes");
            DropForeignKey("dbo.HouseStyles", "ImgResource_imgID", "dbo.ImgResources");
            DropColumn("dbo.ImgResources", "houseStyleID");
            DropColumn("dbo.ImgResources", "houseID");
            DropColumn("dbo.HouseStyles", "ImgResource_imgID");
            
        }
    }
}
