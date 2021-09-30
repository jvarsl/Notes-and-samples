namespace ASPNET_MVC_Framework_EntityCRUD_2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class jokeApplicationUserrelationshipadded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Jokes", "ApplicationUser_Id", c => c.String(maxLength: 128));
            AddColumn("dbo.AspNetUsers", "FirstName", c => c.String(maxLength: 50));
            AddColumn("dbo.AspNetUsers", "LastName", c => c.String(maxLength: 50));
            CreateIndex("dbo.Jokes", "ApplicationUser_Id");
            AddForeignKey("dbo.Jokes", "ApplicationUser_Id", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Jokes", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Jokes", new[] { "ApplicationUser_Id" });
            DropColumn("dbo.AspNetUsers", "LastName");
            DropColumn("dbo.AspNetUsers", "FirstName");
            DropColumn("dbo.Jokes", "ApplicationUser_Id");
        }
    }
}
