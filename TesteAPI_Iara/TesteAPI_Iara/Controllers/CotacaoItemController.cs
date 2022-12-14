using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TesteAPI_Iara.Context;
using TesteAPI_Iara.Models;

namespace TesteAPI_Iara.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CotacaoItemController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CotacaoItemController(AppDbContext context)
        {
            _context=context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<CotacaoItem>> Get()
        {
            var cotacaoItem = _context.ContacaoItems.ToList();

            if (cotacaoItem is null)
            {
                return NotFound();
            }

            return cotacaoItem;
        }

        //Método p/ consultar a cotação pelo ID
        [HttpGet("{id=int}", Name = "ObterCotacaoItem")]
        public ActionResult<CotacaoItem> Get(int id)
        {
            var cotacaoItem = _context?.ContacaoItems.FirstOrDefault(p => p.CotacaoItemId == id);

            if (cotacaoItem is null)
            {
                return NotFound("Cotação do item não encontrada...");
            }
            return cotacaoItem;
        }

        //Método p/ criação de Cotação
        [HttpPost]
        public ActionResult Post(CotacaoItem cotacaoItem)
        {
            if (cotacaoItem is null)
            {
                return BadRequest();
            }

            _context?.ContacaoItems?.Add(cotacaoItem);
            _context?.SaveChanges();

            return new CreatedAtRouteResult("ObterCotacaoItem", new { id = cotacaoItem.CotacaoItemId }, cotacaoItem);
        }

        //Método p/ atualizar
        [HttpPut("{id:int}")]
        public ActionResult Put(int id, CotacaoItem cotacaoItem)
        {
            if (id != cotacaoItem.CotacaoItemId)
            {
                return BadRequest();
            }

            _context.Entry(cotacaoItem).State = EntityState.Modified;
            _context.SaveChanges();

            return Ok();
        }

        //Método p/ excuir
        [HttpDelete("{id:int}")]
        public ActionResult Delete(int id)
        {
            var cotacaoItem = _context?.ContacaoItems?.FirstOrDefault(p => p.CotacaoItemId == id);

            if (cotacaoItem is null)
            {
                return NotFound("Cotação do item não localizada...");
            }

            _context?.ContacaoItems?.Remove(cotacaoItem);
            _context?.SaveChanges();

            return Ok(cotacaoItem);
        }

    }
}
