using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TrackMyDay.Models
{
    public class ReminderInfo
    {
        [Key]
        [DatabaseGenerated( DatabaseGeneratedOption.Identity)]
        public int ReminderId { get; set; }

        public int ReminderTypeId { get; set; }

        public DateTime? ReminderTime { get; set; }

        [ForeignKey("TaskInfo")]
        public Guid TaskId { get; set; }

        public virtual TaskInfo TaskInfo { get; set; }

        public virtual ICollection<SnoozeInfo> SnoozeInfo { get; set; }
    }
}