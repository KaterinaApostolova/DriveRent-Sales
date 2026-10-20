using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;

namespace DriveRent_Sales.Models
{
    public class VehicleSale
    {
        [Key]
        public int IdVehicleSale { get; set; }

        [Required, StringLength(45)]
        public string Model { get; set; }

        [Required, StringLength(45)]
        public string Brand { get; set; }

        [Required]
        public int Year { get; set; }

        [Required, StringLength(45)]
        public string Fuels { get; set; }

        [Required, StringLength(45)]
        public string Gearbox { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public bool Status { get; set; }
    }
}
