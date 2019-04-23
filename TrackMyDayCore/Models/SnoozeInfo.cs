using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TrackMyDay.Models
{
    public class SnoozeInfo
    {
        [Key]
        [DatabaseGenerated( DatabaseGeneratedOption.Identity)]
        public int SnoozeId { get; set; }

        public int Day { get; set; }

        public int Hour { get; set; }

        public int Minute { get; set; }
        [ForeignKey("ReminderInfo")]
        public int ReminderId { get; set; }
        public virtual ReminderInfo ReminderInfo { get; set; }
    }
}