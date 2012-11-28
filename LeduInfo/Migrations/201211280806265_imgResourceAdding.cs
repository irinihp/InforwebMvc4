namespace LeduInfo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class imgResourceAdding : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ImgResources",
                c => new
                    {
                        imgID = c.Int(nullable: false, identity: true),
                        imgPath = c.String(),
                        spanNum = c.Int(nullable: false),
                        AltMsg = c.String(),
                        Description = c.String(),
                        smallDes = c.String(),
                        warpwordsTitle = c.String(),
                        warpContent = c.String(),
                    })
                .PrimaryKey(t => t.imgID);
            AddColumn("dbo.OwnerInfoes", "phoneNumber", c => c.Long(nullable: false));
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ImgResources");

        }
    }
}
