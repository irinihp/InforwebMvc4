namespace LeduInfo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addtblforvote : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.VoteComments",
                c => new
                    {
                        CommentID = c.Int(nullable: false, identity: true),
                        Comments = c.String(),
                    })
                .PrimaryKey(t => t.CommentID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.VoteComments");
        }
    }
}
