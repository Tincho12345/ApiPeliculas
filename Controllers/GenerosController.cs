using ApiPeliculas.DTOs;
using ApiPeliculas.Entidades;
using ApiPeliculas.Utilidades;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ApiPeliculas.Controllers
{
    [Route("api/generos")]
    [ApiController]
    public class GenerosController : ControllerBase
    {
        #region Constructor
        private readonly ILogger<GenerosController> logger;
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public GenerosController(ILogger<GenerosController> logger,
                                 ApplicationDbContext context,
                                 IMapper mapper)
        {
            this.logger = logger;
            this.context = context;
            this.mapper = mapper;
        }
        #endregion

        #region Get
        [HttpGet] // api/generos
        public async Task<ActionResult<List<GeneroDTO>>> Get([FromQuery] PaginacionDTO paginacionDTO)
        {
            var queryable = context.Generos.AsQueryable();
            await HttpContext.InsertarParametrosPaginacionEnCabecera(queryable);

            var generos = await queryable.OrderBy(x => x.Nombre).Paginar(paginacionDTO).ToListAsync();
            return mapper.Map<List<GeneroDTO>>(generos);
        }

        [HttpGet("{Id:int}")] // api/generos/Id
        public async Task<ActionResult<GeneroDTO>> GetById(int Id)
        {
            var genero = await context.Generos.FirstOrDefaultAsync(x => x.Id == Id);

            if (genero == null) 
                return NotFound();
            return Ok(mapper.Map<GeneroDTO>(genero));
        }

        #endregion

        #region PostPutDelete
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] GeneroCreacionDTO generoCreacionDto)
        {
            var genero = mapper.Map<Genero>(generoCreacionDto);
            context.Add(genero);
            await context.SaveChangesAsync();
            return NoContent();// para Retornar un 204
        }

        [HttpPut]
        public async Task<ActionResult> Put(int Id, [FromBody] GeneroDTO generoDTO)
        {
            var genero = await context.Generos.FirstOrDefaultAsync(x => x.Id == Id);

            if (genero == null) return NotFound();

            genero = mapper.Map(generoDTO, genero);

            await context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete]
        public ActionResult Delete()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
