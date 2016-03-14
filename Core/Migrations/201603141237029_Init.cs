namespace Core.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ByPassLists",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        WorkerId = c.Guid(nullable: false),
                        IsComplete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.WorkerId, cascadeDelete: true)
                .Index(t => t.WorkerId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Email = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        Inn = c.String(nullable: false),
                        DepartmentId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ByPassStates",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Position = c.Int(nullable: false),
                        ByPassListId = c.Guid(nullable: false),
                        IsComplete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ByPassLists", t => t.ByPassListId, cascadeDelete: true)
                .Index(t => t.ByPassListId);
            
            CreateTable(
                "dbo.ByPassStateSteps",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        DepartmentId = c.Guid(nullable: false),
                        ApprovedChiefId = c.Guid(nullable: false),
                        IsComplete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.ApprovedChiefId, cascadeDelete: true)
                .ForeignKey("dbo.Departments", t => t.DepartmentId, cascadeDelete: true)
                .Index(t => t.DepartmentId)
                .Index(t => t.ApprovedChiefId);
            
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Name = c.String(),
                        Details = c.String(),
                        ChiefId = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.ChiefId)
                .Index(t => t.ChiefId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ByPassStateSteps", "DepartmentId", "dbo.Departments");
            DropForeignKey("dbo.Departments", "ChiefId", "dbo.Users");
            DropForeignKey("dbo.ByPassStateSteps", "ApprovedChiefId", "dbo.Users");
            DropForeignKey("dbo.ByPassStates", "ByPassListId", "dbo.ByPassLists");
            DropForeignKey("dbo.ByPassLists", "WorkerId", "dbo.Users");
            DropIndex("dbo.Departments", new[] { "ChiefId" });
            DropIndex("dbo.ByPassStateSteps", new[] { "ApprovedChiefId" });
            DropIndex("dbo.ByPassStateSteps", new[] { "DepartmentId" });
            DropIndex("dbo.ByPassStates", new[] { "ByPassListId" });
            DropIndex("dbo.ByPassLists", new[] { "WorkerId" });
            DropTable("dbo.Departments");
            DropTable("dbo.ByPassStateSteps");
            DropTable("dbo.ByPassStates");
            DropTable("dbo.Users");
            DropTable("dbo.ByPassLists");
        }
    }
}
