using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TrackMyDay.Models
{
    public class ReminderInfoHistory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int id { get; set; }
        public int ReminderId { get; set; }

        public int ReminderTypeId { get; set; }

        public DateTime? ReminderTime { get; set; }

        public Guid TaskId { get; set; }

    }
}