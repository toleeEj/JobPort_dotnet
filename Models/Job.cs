using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        // Foreign Key to Users
        [ForeignKey("User")]
        [NotMapped]
        public int EmployerId { get; set; }

        // Navigation property
        [NotMapped]
        public virtual User? Employer { get; set; }= null;
        

        //(Jobs can have many applications)
        [NotMapped]
        public ICollection<Application>? Applications { get; set; }=null;
    }
}
