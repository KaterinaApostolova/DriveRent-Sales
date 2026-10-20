using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;

namespace DriveRent_Sales.Models
{
    public class RentalBooking
    {
        [Key, ForeignKey(nameof(IdUser))]
        public int IdUser { get; set; }

        [Key, ForeignKey(nameof(IdVehicleRent))]
        public int IdVehicleRent { get; set; }

        [Required]
        public DateOnly PeriodStart { get; set; }

        [Required]
        public DateOnly PeriodEnd { get; set; }
    }
}
