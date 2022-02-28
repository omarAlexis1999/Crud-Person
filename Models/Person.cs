using System.ComponentModel.DataAnnotations;

namespace ControlIngresoGasto.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(70)]
        [Display(Name ="Name")]
        public string name { get; set; }

        [Required]
        [MaxLength(70)]
        [Display(Name = "Lastname")]
        public string lastName { get; set; }

        [Required]
        [MaxLength(15)]
        [Display(Name = "DNI")]
        public string dni { get; set; }

        [MaxLength(110)]
        [Display(Name = "Address")]
        public string address { get; set; }

        [MaxLength(110)]
        [Display(Name = "Country")]
        public string country { get; set; }

        [MaxLength(110)]
        [Display(Name = "City")]
        public string city { get; set; }

        [MaxLength(20)]
        [Display(Name = "Gender")]
        public string gender { get; set; }

        [Required]
        [Display(Name = "Status")]
        public bool status { get; set; }

        [Required]
        [Display(Name = "Birthday")]
        public DateTime birth { get; set; }
    }
}
