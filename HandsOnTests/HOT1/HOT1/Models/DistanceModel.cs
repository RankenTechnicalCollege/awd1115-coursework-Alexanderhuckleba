using System.ComponentModel.DataAnnotations;

namespace HOT1.Models
{
    public class DistanceModel
    {
        [Required(ErrorMessage = "Distance is required.")]
        [Range(1, 500, ErrorMessage = "Distance must be between 1 and 500.")]
        [Display(Name = "Distance (inches)")]
        public double? Inches { get; set; }

        public double Centimeters => Inches.HasValue ? Inches.Value * 2.54 : 0;
    }
}
