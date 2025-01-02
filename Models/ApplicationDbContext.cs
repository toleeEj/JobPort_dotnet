using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using JobPortal.Models;

namespace JobPortal.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Job> Jobs { get; set; }
        public DbSet<Application> Applications { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        public DbSet<User> Users { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure the relationship between Job and ApplicationUser
            modelBuilder.Entity<Job>()
                .HasOne(j => j.Employer)
                .WithMany() // Assuming employers do not have a navigation property for jobs
                .HasForeignKey(j => j.EmployerId)
                .OnDelete(DeleteBehavior.Restrict); // Use appropriate delete behavior
        }

    }

    

}
