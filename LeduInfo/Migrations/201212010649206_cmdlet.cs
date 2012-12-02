namespace LeduInfo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cmdlet : DbMigration
    {
        public override void Up()
        {
            AddForeignKey("dbo.ImgResources", "houseStyleID", "dbo.HouseStyles", "houseStyleID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ImgResources", "houseStyleID", "dbo.HouseStyles" );
        }
    }
}
