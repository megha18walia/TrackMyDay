namespace TrackMyDay.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using TrackMyDay.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<TrackMyDay.Models.TrackMyDayContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "TrackMyDayDAL.TrackMyDayContext";
        }

        protected override void Seed(TrackMyDay.Models.TrackMyDayContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            int countReminder = context.Reminders.Count();
            if (countReminder == 0)
            {
                List<Reminder> lstReminder = new List<Reminder>();
                lstReminder.Add(new Reminder { ReminderType = "Email" });
                lstReminder.Add(new Reminder { ReminderType = "SMS" });
                lstReminder.Add(new Reminder { ReminderType = "Watsapp" });
                context.Reminders.AddRange(lstReminder);
                context.Reminders.AddOrUpdate();
            }
        }
    }
}
