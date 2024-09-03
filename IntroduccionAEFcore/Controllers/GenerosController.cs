using IntroduccionAEFcore.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace IntroduccionAEFcore.Controllers
{
    [ApiController]
    [Route("api/generos")]
    public class GenerosController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public GenerosController(ApplicationDbContext context)
        {

            _context = context;

        }

        [HttpPost]
        public async Task<ActionResult> Post(Genero genero)
        {
            //segun llega todo el grafo  para meter info hasta de pelicula y para eso se crea DTOs
            _context.Add(genero);
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpPost("varios")]
        public async Task<ActionResult> Post(Genero[] generos)
        {
            //segun llega todo el grafo  para meter info hasta de pelicula y para eso se crea DTOs
            _context.AddRange(generos);
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
