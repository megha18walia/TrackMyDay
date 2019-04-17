using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using TrackMyDay.Migrations;

namespace TrackMyDay.Models
{
    public class TrackMyDayContext : DbContext
    {
        public TrackMyDayContext() : base("name=TrackMyDayConnection")
        {
            //  Database.SetInitializer<TrackMyDayContext>(new CreateDatabaseIfNotExists<TrackMyDayContext>());
            Database.SetInitializer<TrackMyDayContext>(new MigrateDatabaseToLatestVersion<TrackMyDayContext, Configuration>());
        }
        public DbSet<AspNetUsers> AspNetUserss { get; set; }
        public DbSet<TaskInfo> TaskInfos { get; set; }

        public DbSet<Reminder> Reminders { get; set; }

        public DbSet<ReminderInfo> ReminderInfos { get; set; }

        public DbSet<TaskAssignmentInfo> TaskAssignmentInfos { get; set; }

        public DbSet<SnoozeInfo> SnoozeInfos { get; set; }

        public DbSet<ReminderInfoHistory> ReminderInfoHistories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }


    }


}