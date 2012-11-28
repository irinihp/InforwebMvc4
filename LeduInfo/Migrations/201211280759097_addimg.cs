namespace LeduInfo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addimg : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.OwnerInfoes", "phoneNum", c => c.Long(nullable: false));
            
        }
        
        public override void Down()
        {
            AddColumn("dbo.OwnerInfoes", "phoneNumber", c => c.Long(nullable: false));
            
        }
    }
}
