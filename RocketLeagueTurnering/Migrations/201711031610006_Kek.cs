namespace RocketLeagueTurnering.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Kek : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Teams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TeamName = c.String(),
                        Medlem1 = c.String(),
                        Medlem2 = c.String(),
                        Medlem3 = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Teams");
        }
    }
}
