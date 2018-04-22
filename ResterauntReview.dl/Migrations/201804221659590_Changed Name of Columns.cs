namespace ResterauntReview.dl.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedNameofColumns : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Reviews", "Resteraunt_ResterauntId", "dbo.Resteraunts");
            RenameColumn(table: "dbo.Reviews", name: "Resteraunt_ResterauntId", newName: "Resteraunt_Id");
            RenameIndex(table: "dbo.Reviews", name: "IX_Resteraunt_ResterauntId", newName: "IX_Resteraunt_Id");
            DropPrimaryKey("dbo.Resteraunts");
            AddColumn("dbo.Resteraunts", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Resteraunts", "Id");
            AddForeignKey("dbo.Reviews", "Resteraunt_Id", "dbo.Resteraunts", "Id");
            DropColumn("dbo.Resteraunts", "ResterauntId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Resteraunts", "ResterauntId", c => c.Int(nullable: false, identity: true));
            DropForeignKey("dbo.Reviews", "Resteraunt_Id", "dbo.Resteraunts");
            DropPrimaryKey("dbo.Resteraunts");
            DropColumn("dbo.Resteraunts", "Id");
            AddPrimaryKey("dbo.Resteraunts", "ResterauntId");
            RenameIndex(table: "dbo.Reviews", name: "IX_Resteraunt_Id", newName: "IX_Resteraunt_ResterauntId");
            RenameColumn(table: "dbo.Reviews", name: "Resteraunt_Id", newName: "Resteraunt_ResterauntId");
            AddForeignKey("dbo.Reviews", "Resteraunt_ResterauntId", "dbo.Resteraunts", "ResterauntId");
        }
    }
}
