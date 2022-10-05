using System.ComponentModel.DataAnnotations;

namespace la_mia_pizzeria.Utils.Validation
{
    public class NotNegativeOrZeroAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object? value, ValidationContext validationContext)
        {
            int fieldValue = (int)value;
            if (fieldValue <= 0)
            {
                return new ValidationResult("Il numero non puo essere minore o uguale a zero");
            }
            return ValidationResult.Success;
        }
    }
}