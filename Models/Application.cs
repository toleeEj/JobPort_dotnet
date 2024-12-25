using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobPortal.Models
{
    public class Application
    {
        [Key]
        public int ApplicationId { get; set; }

        [Required]
        public DateTime AppliedDate { get; set; }

        [ForeignKey("Job")]
        public int JobId { get; set; }
        public required Job Job { get; set; }

        [ForeignKey("User")]
        public required string Id { get; set; }
        public required ApplicationUser User { get; set; }

        public required string Status { get; set; }
        public required string Notes { get; set; }
    }
}
