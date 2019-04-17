namespace TrackMyDay.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TMD1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ReminderInfoHistory",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        ReminderId = c.Int(nullable: false),
                        ReminderTypeId = c.Int(nullable: false),
                        ReminderTime = c.DateTime(),
                        TaskId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ReminderInfoHistory");
        }
    }
}
