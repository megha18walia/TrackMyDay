using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using TrackMyDay.Models;


namespace TrackMyDay.Models
{
    public class AspNetUsers
    {
        [Key]
        [MaxLength(450)]
        public string Id { get; set; }
        [MaxLength(256)]
        public string Email { get; set; }
        public bool EmailConfirmed { get; set; }
        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }
        public string PhoneNumber { get; set; }

        public bool PhoneNumberConfirmed { get; set; }

        public bool TwoFactorEnabled { get; set; }

        public DateTime LockoutEndDateUtc { get; set; }

        public bool LockoutEnabled { get; set; }

        public int AccessFailedCount { get; set; }

        [MaxLength(256)]
        public string UserName { get; set; }

      

        public virtual ICollection< TaskInfo>  Task { get; set; }

        public virtual ICollection<TaskAssignmentInfo> TaskAssignment { get; set; }

    }
}