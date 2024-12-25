using System.ComponentModel.DataAnnotations;

namespace JobPortal.Models
{
    public class User
    {
        public int Id { get; set; }  
   
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string Email { get; set; }
        public required string Password { get; set; }  
        public required string Role { get; set; }  
        public DateTime DateRegistered { get; set; } = DateTime.Now;
    }
}