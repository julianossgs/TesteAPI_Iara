using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TesteAPI_Iara.Context;
using TesteAPI_Iara.Models;
using Microsoft.EntityFrameworkCore;

namespace TesteAPI_Iara.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CotacaoController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CotacaoController(AppDbContext context)
        {
            _context=context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Cotacao>> Get()
        {
            var cotacao = _context.Cotacoes.ToList();

            if (cotacao is null)
            {
                return NotFound();
            }

            return cotacao;
        }

        //Método p/ consultar a cotação pelo ID
        [HttpGet("{id=int}",Name ="ObterCotacao")]
        public ActionResult<Cotacao> Get(int id) 
        {
            var cotacao = _context?.Cotacoes?.FirstOrDefault(p => p.CotacaoId == id);

            if (cotacao is null)
            {
                return NotFound("Cotação não encontrada...");
            }
            return cotacao;
        }

        //Método p/ criação de Cotação
        [HttpPost]
        public ActionResult Post(Cotacao cotacao)
        {
            if (cotacao is null)
            {
                return BadRequest();
            }

            _context?.Cotacoes?.Add(cotacao);
            _context?.SaveChanges();

            return new CreatedAtRouteResult("ObterCotacao", new { id = cotacao.CotacaoId }, cotacao);
        }

        //Método p/ atualizar
        [HttpPut("{id:int}")]
        public ActionResult Put(int id,Cotacao cotacao)
        {
            if (id != cotacao.CotacaoId)
            {
                return BadRequest();
            }

            _context.Entry(cotacao).State = EntityState.Modified;
            _context.SaveChanges();

            return Ok();
        }

        //Método p/ excuir
        [HttpDelete("{id:int}")]
        public ActionResult Delete(int id)
        {
            var cotacao = _context?.Cotacoes?.FirstOrDefault(p =>p.CotacaoId == id);

            if (cotacao is null)
            {
                return NotFound("Cotação não localizada...");
            }

            _context?.Cotacoes?.Remove(cotacao);
            _context?.SaveChanges();

            return Ok(cotacao);
        }

    }
}
