namespace Core.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddStatestepsRelMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ByPassStateSteps", "ByPassStateId", c => c.Guid(nullable: false));
            CreateIndex("dbo.ByPassStateSteps", "ByPassStateId");
            AddForeignKey("dbo.ByPassStateSteps", "ByPassStateId", "dbo.ByPassStates", "Id", cascadeDelete: false);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ByPassStateSteps", "ByPassStateId", "dbo.ByPassStates");
            DropIndex("dbo.ByPassStateSteps", new[] { "ByPassStateId" });
            DropColumn("dbo.ByPassStateSteps", "ByPassStateId");
        }
    }
}
