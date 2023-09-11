using System.ComponentModel.DataAnnotations;

namespace ApiPeliculas.Validaciones
{
    public class PrimeraLetraMayusculaAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null || string.IsNullOrEmpty(value.ToString()))
            {
                
            };

            var primeraLetra = value.ToString()[0].ToString();
            if (primeraLetra != primeraLetra.ToUpper())
            {
                return new ValidationResult("La primera Letra debe ser Mayúscula");
            }
            return ValidationResult.Success;
        }
    }
}
