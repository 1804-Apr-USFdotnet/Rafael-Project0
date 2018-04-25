namespace ResterauntReview.dl.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedColumns : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Reviews", "ResterauntId", "dbo.Resteraunts");
            AddColumn("dbo.Resteraunts", "Address", c => c.String());
            AddColumn("dbo.Resteraunts", "City", c => c.String());
            AddColumn("dbo.Resteraunts", "reviews_ReviewId", c => c.Int());
            AddColumn("dbo.Reviews", "Resteraunt_ResterauntId", c => c.Int());
            CreateIndex("dbo.Resteraunts", "reviews_ReviewId");
            CreateIndex("dbo.Reviews", "Resteraunt_ResterauntId");
            AddForeignKey("dbo.Resteraunts", "reviews_ReviewId", "dbo.Reviews", "ReviewId");
            AddForeignKey("dbo.Reviews", "Resteraunt_ResterauntId", "dbo.Resteraunts", "ResterauntId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reviews", "Resteraunt_ResterauntId", "dbo.Resteraunts");
            DropForeignKey("dbo.Resteraunts", "reviews_ReviewId", "dbo.Reviews");
            DropIndex("dbo.Reviews", new[] { "Resteraunt_ResterauntId" });
            DropIndex("dbo.Resteraunts", new[] { "reviews_ReviewId" });
            DropColumn("dbo.Reviews", "Resteraunt_ResterauntId");
            DropColumn("dbo.Resteraunts", "reviews_ReviewId");
            DropColumn("dbo.Resteraunts", "City");
            DropColumn("dbo.Resteraunts", "Address");
            AddForeignKey("dbo.Reviews", "ResterauntId", "dbo.Resteraunts", "ResterauntId", cascadeDelete: true);
        }
    }
}
