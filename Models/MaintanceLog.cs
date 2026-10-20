using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;

namespace DriveRent_Sales.Models
{
    public class MaintanceLog
    {
        [Key]
        public int IdMaintanceLog { get; set; }

        [ForeignKey(nameof(IdMaintanceLog)), Required]
        public int IdVehicleRent { get; set; }

        [Required]
        public string Description { get; set; }
    }
}
