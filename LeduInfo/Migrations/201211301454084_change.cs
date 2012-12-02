namespace LeduInfo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class change : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ImgResources", "houseStyleID", c => c.Int(nullable: false));
            AddForeignKey("dbo.ImgResources", "houseStyleID", "dbo.HouseStyles", "houseStyleID", cascadeDelete: false);

        }
        
        public override void Down()
        {
        }
    }
}
