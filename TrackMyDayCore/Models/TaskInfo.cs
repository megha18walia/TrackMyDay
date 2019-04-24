using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using TrackMyDay.Models;

namespace TrackMyDay.Models
{
    public class TaskInfo
    {
        [Key]
        public Guid TaskId { get; set; }

        [MaxLength(128)]
        public string TaskType { get; set; }

        public string TaskDescription { get; set; }

        [ForeignKey("AspNetUsers")]
        [MaxLength(450)]
        public string CreatedBy { get; set; }

        public virtual AspNetUsers AspNetUsers { get; set; }

        public virtual ICollection<ReminderInfo> ReminderInfo { get; set; }

        public virtual ICollection<TaskAssignmentInfo> TaskAssignment { get; set; }
    }
}