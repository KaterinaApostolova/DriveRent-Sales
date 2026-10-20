using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;

namespace DriveRent_Sales.Models
{
    public class Role
    {
        [Key]
        public int IdRole { get; set; }

        [StringLength(45), Required]
        public string Name { get; set; }
    }
}
