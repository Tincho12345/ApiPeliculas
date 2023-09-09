using System.ComponentModel.DataAnnotations;

namespace ApiPeliculas.Entidades
{
    public class Genero
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="El Campo {0} es requerido!")]
        [MaxLength(50)]
        public string Nombre { get; set; }
    }
}
