using Microsoft.EntityFrameworkCore;
using TesteAPI_Iara.Models;

namespace TesteAPI_Iara.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :base(options) { }

        //Mapeamento das entidades
        public DbSet<CotacaoItem>? ContacaoItems { get; set; }
        public DbSet<Cotacao>? Cotacoes { get; set; }
    }
}
