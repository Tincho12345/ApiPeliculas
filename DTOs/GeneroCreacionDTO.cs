using ApiPeliculas.Validaciones;
using System.ComponentModel.DataAnnotations;

namespace ApiPeliculas.DTOs
{
    public class GeneroCreacionDTO
    {
        [Required(ErrorMessage = "El Campo {0} es requerido!")]
        [StringLength(maximumLength: 50)]
        [PrimeraLetraMayuscula]
        public string Nombre { get; set; }
    }
}
