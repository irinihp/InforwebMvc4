namespace LeduInfo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddImgpath : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ImgPaths",
                c => new
                    {
                        pathID = c.Int(nullable: false, identity: true),
                        Path = c.String(),
                    })
                .PrimaryKey(t => t.pathID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ImgPaths");
        }
    }
}
