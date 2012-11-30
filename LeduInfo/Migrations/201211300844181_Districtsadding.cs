namespace LeduInfo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Districtsadding : DbMigration
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
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Districts");
        }
    }
}
