using la_mia_pizzeria.Utils.Validation;
using System.ComponentModel.DataAnnotations;

namespace la_mia_pizzeria.Models
{
    public class Pizza
    {
        
        public int Id { get; set; }

        [Required(ErrorMessage = "Il campo nome è obbligatorio")]
        [StringLength(25, ErrorMessage = "Il nome non può avere più di 25 caratteri")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Il campo nome è obbligatorio")]
        [StringLength(255, ErrorMessage = "Il nome non può avere più di 255 caratteri")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Il campo descrizione è obbligatorio")]
        public string Image { get; set; }

        [Required(ErrorMessage = "Il campo prezzo è obbligatorio")]
        [NotNegativeOrZero]
        public double Price { get; set; }
    }
}
