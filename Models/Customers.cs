using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LHPets.Models
{
    [Table("Customers")]
    public class Customers{

        [Key]
        [Column("Id")]
        [Display(Name = "Id")]
        public int Id { get; set; }
        [Column("Name")]
        [Display(Name = "Name")]        
        public string? Name { get; set; }
        [Column("ITIN")]
        [Display(Name = "ITIN")]        
        public int ITIN { get; set; }
        [Column("Email")]
        [Display(Name = "Email")]
        public string? Email { get; set; }
        [Column("Patient")]
        [Display(Name = "Patient")]        
        public string? Patient { get; set; }
    }
}