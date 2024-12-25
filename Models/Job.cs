using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace JobPortal.Models
{
    public class Job
    {
        [Key]
        public int JobId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Requirements { get; set; }

        public string Location { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Salary must be a positive value.")]
        public decimal Salary { get; set; }

        public DateTime PostedDate { get; set; }

        public DateTime Deadline { get; set; }

        // Foreign Key to Users (Employer)
        public int Id { get; set; }

        // Navigation property to the Employer (User)
        public virtual ApplicationUser? Employer { get; set; }

        // Navigation property to Applications (Jobs can have many applications)
        public ICollection<Application> Applications { get; set; }
    }
}
