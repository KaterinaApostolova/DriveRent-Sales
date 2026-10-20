using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;
using DriveRent_Sales.Models;

namespace DriveRent_Sales.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [StringLength(45), Required]
        public string Username { get; set; }

        [EmailAddress, StringLength(100), Required]
        public string Email { get; set; }

        [PasswordPropertyText, StringLength(45), Required]
        public string passwordHash { get; set; }

        [Required, Range(18,100)]
        public int age { get; set; }

        [ForeignKey(nameof(IdRole)), Required]
        public int IdRole { get; set; }

        
        public Blob drivingLicense { get; set; }
    }
}
