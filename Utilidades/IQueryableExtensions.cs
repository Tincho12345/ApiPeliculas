using ApiPeliculas.DTOs;
using System.Linq;

namespace ApiPeliculas.Utilidades
{
    public static class IQueryableExtensions
    {
        public static IQueryable<T> Paginar<T>(this IQueryable<T> queryable, PaginacionDTO paginacionDTO)
        {
            return queryable
                .Skip((paginacionDTO.Pagina - 1) * paginacionDTO.RecordPorPagina)
                .Take(paginacionDTO.RecordPorPagina);
        }
    }
}
