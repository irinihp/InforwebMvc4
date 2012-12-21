namespace LeduInfo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addnewcolumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.VoteComments", "ViewPoint", c => c.Boolean(nullable: false));
            AddColumn("dbo.VoteComments", "UserID", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.VoteComments", "UserID");
            DropColumn("dbo.VoteComments", "ViewPoint");
        }
    }
}
