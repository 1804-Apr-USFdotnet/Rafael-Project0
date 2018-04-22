namespace ResterauntReview.dl.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Resteraunt : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Resteraunts",
                c => new
                    {
                        ResterauntId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ResterauntId);
            
            CreateTable(
                "dbo.Reviews",
                c => new
                    {
                        ReviewId = c.Int(nullable: false, identity: true),
                        EmailOfReviewer = c.String(),
                        Rating = c.Double(nullable: false),
                        ReviewComment = c.String(),
                        DateOfReview = c.DateTime(nullable: false),
                        Resteraunt_ResterauntId = c.Int(),
                    })
                .PrimaryKey(t => t.ReviewId)
                .ForeignKey("dbo.Resteraunts", t => t.Resteraunt_ResterauntId)
                .Index(t => t.Resteraunt_ResterauntId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reviews", "Resteraunt_ResterauntId", "dbo.Resteraunts");
            DropIndex("dbo.Reviews", new[] { "Resteraunt_ResterauntId" });
            DropTable("dbo.Reviews");
            DropTable("dbo.Resteraunts");
        }
    }
}
