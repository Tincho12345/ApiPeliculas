using System.ComponentModel.DataAnnotations;

namespace ApiPeliculas.DTOs
{
    public class GeneroCreacionDTO
    {
        [Required(ErrorMessage = "El Campo {0} es requerido!")]
        [MaxLength(50)]
        public string Nombre { get; set; }
    }
}
