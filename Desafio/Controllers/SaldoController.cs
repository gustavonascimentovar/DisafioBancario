using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using WebDesafio.Application.Conta;
using WebDesafio.Application.saldo;
using WebDesafio.Repository;
using WebDesafio.Repository.model;

namespace Desafio.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SaldoController : ControllerBase
    {

        private readonly DesafioContext _context;
        public SaldoController(DesafioContext context)
        {
            _context = context;
        }


        [HttpGet]

        public IActionResult PegarSaldo(SaldoRequest request)
        {
            var saldoservice = new SaldoService(_context);
           var sucesso = saldoservice.PegarSaldo(request);
            if(sucesso != null)
            {
                return Ok(sucesso);
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
