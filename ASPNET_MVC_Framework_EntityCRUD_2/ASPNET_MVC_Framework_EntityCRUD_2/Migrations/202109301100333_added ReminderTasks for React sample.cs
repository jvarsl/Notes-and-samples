namespace ASPNET_MVC_Framework_EntityCRUD_2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedReminderTasksforReactsample : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ReminderTasks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Text = c.String(),
                        DayAndTime = c.DateTime(nullable: false),
                        Reminder = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ReminderTasks");
        }
    }
}
