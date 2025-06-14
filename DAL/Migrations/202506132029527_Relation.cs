namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Relation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.comments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CommentText = c.String(nullable: false),
                        Time = c.DateTime(nullable: false),
                        CommentedBy = c.String(maxLength: 128),
                        PostId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.posts", t => t.PostId)
                .ForeignKey("dbo.users", t => t.CommentedBy)
                .Index(t => t.CommentedBy)
                .Index(t => t.PostId);
            
            CreateTable(
                "dbo.posts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        Description = c.String(nullable: false),
                        PostedBy = c.String(maxLength: 128),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.users", t => t.PostedBy)
                .Index(t => t.PostedBy);
            
            CreateTable(
                "dbo.users",
                c => new
                    {
                        Uname = c.String(nullable: false, maxLength: 128),
                        Password = c.String(nullable: false, maxLength: 20),
                        Name = c.String(nullable: false, maxLength: 20),
                        Type = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Uname);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.comments", "CommentedBy", "dbo.users");
            DropForeignKey("dbo.comments", "PostId", "dbo.posts");
            DropForeignKey("dbo.posts", "PostedBy", "dbo.users");
            DropIndex("dbo.posts", new[] { "PostedBy" });
            DropIndex("dbo.comments", new[] { "PostId" });
            DropIndex("dbo.comments", new[] { "CommentedBy" });
            DropTable("dbo.users");
            DropTable("dbo.posts");
            DropTable("dbo.comments");
        }
    }
}
