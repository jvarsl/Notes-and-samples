namespace ConsoleApp5_NetFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedbunchofrelationships : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        CityId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cities", t => t.CityId, cascadeDelete: true)
                .Index(t => t.CityId);
            
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PostGenres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        GenreId = c.Int(nullable: false),
                        PostId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Genres", t => t.GenreId, cascadeDelete: true)
                .ForeignKey("dbo.Posts", t => t.PostId, cascadeDelete: true)
                .Index(t => t.GenreId)
                .Index(t => t.PostId);
            
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Posts", "AuthorId", c => c.Int(nullable: false));
            CreateIndex("dbo.Posts", "AuthorId");
            AddForeignKey("dbo.Posts", "AuthorId", "dbo.Authors", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PostGenres", "PostId", "dbo.Posts");
            DropForeignKey("dbo.PostGenres", "GenreId", "dbo.Genres");
            DropForeignKey("dbo.Posts", "AuthorId", "dbo.Authors");
            DropForeignKey("dbo.Authors", "CityId", "dbo.Cities");
            DropIndex("dbo.PostGenres", new[] { "PostId" });
            DropIndex("dbo.PostGenres", new[] { "GenreId" });
            DropIndex("dbo.Posts", new[] { "AuthorId" });
            DropIndex("dbo.Authors", new[] { "CityId" });
            DropColumn("dbo.Posts", "AuthorId");
            DropTable("dbo.Genres");
            DropTable("dbo.PostGenres");
            DropTable("dbo.Cities");
            DropTable("dbo.Authors");
        }
    }
}
