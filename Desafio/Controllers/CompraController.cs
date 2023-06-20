using Microsoft.AspNetCore.Mvc;
using WebDesafio.Application.Compra;
using WebDesafio.Repository;

namespace Desafio.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CompraController : ControllerBase
    {

        private readonly DesafioContext _context;
        public CompraController(DesafioContext context)
        {
            _context = context;
        }

        [HttpPost]

        public string TransacaoPagamento(ComprarRequest request)
        {
            var DadosComprar = new comprarService(_context);
            var sucesso = DadosComprar.TransacaoCompra(request);

            
           if(sucesso == true)
            {
                return "transação efetuada com sucesso" ;
            }
            else
            {
                return "transação recusada";
            }
        }

    }
}
