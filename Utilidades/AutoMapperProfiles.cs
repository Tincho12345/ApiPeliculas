using ApiPeliculas.DTOs;
using ApiPeliculas.Entidades;
using AutoMapper;

namespace ApiPeliculas.Utilidades
{
    public class AutoMapperProfiles: Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Genero, GeneroDTO>().ReverseMap();
            CreateMap<GeneroCreacionDTO, Genero>();
        }
    }
}
