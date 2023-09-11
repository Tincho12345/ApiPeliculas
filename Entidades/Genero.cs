using ApiPeliculas.Validaciones;
using System.ComponentModel.DataAnnotations;

namespace ApiPeliculas.Entidades
{
    public class Genero
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="El Campo {0} es requerido!")]
        [StringLength(maximumLength:50)]
        [PrimeraLetraMayuscula]
        public string Nombre { get; set; }
    }
}
