namespace ResterauntReview.dl.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedResterauntId : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Reviews", "Resteraunt_ResterauntId", "dbo.Resteraunts");
            DropIndex("dbo.Reviews", new[] { "Resteraunt_ResterauntId" });
            RenameColumn(table: "dbo.Reviews", name: "Resteraunt_ResterauntId", newName: "ResterauntId");
            AlterColumn("dbo.Reviews", "ResterauntId", c => c.Int(nullable: false));
            CreateIndex("dbo.Reviews", "ResterauntId");
            AddForeignKey("dbo.Reviews", "ResterauntId", "dbo.Resteraunts", "ResterauntId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reviews", "ResterauntId", "dbo.Resteraunts");
            DropIndex("dbo.Reviews", new[] { "ResterauntId" });
            AlterColumn("dbo.Reviews", "ResterauntId", c => c.Int());
            RenameColumn(table: "dbo.Reviews", name: "ResterauntId", newName: "Resteraunt_ResterauntId");
            CreateIndex("dbo.Reviews", "Resteraunt_ResterauntId");
            AddForeignKey("dbo.Reviews", "Resteraunt_ResterauntId", "dbo.Resteraunts", "ResterauntId");
        }
    }
}
