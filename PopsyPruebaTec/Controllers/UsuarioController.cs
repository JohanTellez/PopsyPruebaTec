using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PopsyPruebaTec.Models;

namespace PopsyPruebaTec.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly DbPopsytecContext _context;
        public UsuarioController(DbPopsytecContext context)
        {
            _context = context;
        }

        [HttpGet("listarUsuario")]
        public async Task<ActionResult<IEnumerable<Usuario>>> Listarusuario()
        {
            var usuarios = await _context.Usuarios.ToListAsync();
            return Ok(usuarios);
        }
    }
}
