using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;
using WebDesafio.Application.Atualizar;
using WebDesafio.Repository;

namespace Desafio.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AtualizarCartãoController: ControllerBase
    {

        private readonly DesafioContext _context;
        public AtualizarCartãoController(DesafioContext context)
        {
            _context = context;
        }

        [HttpPut]

        public IActionResult AtualizarCartao(AtualizarRequest request)
        {
            var service = new AtualizarService(_context);
            var sucesso = service.AtualizarCartão(request);

            if(sucesso) 
            {
                return NoContent();
            }
            else
            {
                return BadRequest();
            }
        }
         
    }
}
