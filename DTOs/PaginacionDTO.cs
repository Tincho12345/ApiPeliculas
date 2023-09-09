namespace ApiPeliculas.DTOs
{
    public class PaginacionDTO
    {
        public int Pagina { get; set; } = 1;
        private int recordsPorPagina { get; set; } = 10;

        private readonly int cantidadMaximaRecordsPorPagina = 50;

        public int RecordPorPagina
        {
            get { 
                return recordsPorPagina; 
            }
            set
            {
                recordsPorPagina = (value > cantidadMaximaRecordsPorPagina) ? 
                    cantidadMaximaRecordsPorPagina : value;
            }
        }
    }
}
