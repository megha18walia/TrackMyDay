using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

using System.Linq;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using TrackMyDay.Models;

namespace TrackMyDay.Models
{
    public class TrackMyDayContext :  IdentityDbContext<ApplicationUser>
    {
        
        public TrackMyDayContext(DbContextOptions<TrackMyDayContext> options) : base(options)
        {

            //  Database.SetInitializer<TrackMyDayContext>(new CreateDatabaseIfNotExists<TrackMyDayContext>());
           
        }
        public DbSet<AspNetUsers> AspNetUserss { get; set; }
        public DbSet<TaskInfo> TaskInfos { get; set; }

        public DbSet<Reminder> Reminders { get; set; }

        public DbSet<ReminderInfo> ReminderInfos { get; set; }

        public DbSet<TaskAssignmentInfo> TaskAssignmentInfos { get; set; }

        public DbSet<SnoozeInfo> SnoozeInfos { get; set; }

        public DbSet<ReminderInfoHistory> ReminderInfoHistories { get; set; }

       

    }


}