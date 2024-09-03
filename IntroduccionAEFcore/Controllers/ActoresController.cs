using IntroduccionAEFcore.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace IntroduccionAEFcore.Controllers
{
    [ApiController]
    [Route("api/actores")]
    public class ActoresController: ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public ActoresController(ApplicationDbContext context)
        {

            _context = context;

        }

        [HttpPost]
        public async Task<ActionResult> Post(Actor actor)
        {
            //segun llega todo el grafo  para meter info hasta de pelicula y para eso se crea DTOs
            _context.Add(actor);
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpPost("varios")]
        public async Task<ActionResult> Post(Actor[] actores)
        {
            //segun llega todo el grafo  para meter info hasta de pelicula y para eso se crea DTOs
            _context.AddRange(actores);
            await _context.SaveChangesAsync();
            return Ok();
        }

    }
}
