using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TrackMyDay.Models
{
    public class TaskAssignmentInfo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AssignmentId { get; set; }

        [ForeignKey("TaskInfo")]
        public Guid  TaskId { get; set; }

        [ForeignKey("AspNetUsers")]
        [MaxLength(450)]
        public string AssignedTo { get; set; }

        public string EmailId { get; set; }

        public string MobileNum { get; set; }

        public bool IsSnooze { get; set; }

        public virtual AspNetUsers AspNetUsers { get; set; }

        public virtual TaskInfo TaskInfo { get; set; }
    }
}