using System.ComponentModel.DataAnnotations;
namespace KooliProjekt.Data
{
    public class Customer
    {
        public int CustomerId { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Roll { get; set; }
    }
}
