using Microsoft.AspNetCore.Mvc;
using WebDesafio.Application.AtualizarCartao;
using WebDesafio.Application.DeletarDados;
using WebDesafio.Repository;

namespace Desafio.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DeletarDadosController: ControllerBase
    {

        private readonly DesafioContext _context;
        public DeletarDadosController(DesafioContext context)
        {
            _context = context;
        }

        [HttpDelete]

        public IActionResult DeletarDados(DeletarRequest request)
        {
            var deletarService = new DeletarService(_context);
            var sucesso = deletarService.deletarDadosCartao(request);

            if(sucesso == true)
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
