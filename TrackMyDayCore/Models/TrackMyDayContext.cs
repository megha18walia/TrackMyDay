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
        public DbSet<AspNetUsers> AspNetUser { get; set; }
        public DbSet<TaskInfo> TaskInfo { get; set; }

        public DbSet<Reminder> Reminder { get; set; }

        public DbSet<ReminderInfo> ReminderInfo { get; set; }

        public DbSet<TaskAssignmentInfo> TaskAssignmentInfo { get; set; }

        public DbSet<SnoozeInfo> SnoozeInfo { get; set; }

        public DbSet<ReminderInfoHistory> ReminderInfoHistorie { get; set; }

       

       

    }


}