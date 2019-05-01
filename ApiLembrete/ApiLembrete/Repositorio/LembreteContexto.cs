using ApiLembrete.Entidades;
using Microsoft.EntityFrameworkCore;

namespace ApiLembrete.Repositorio
{
  public class LembreteContexto : DbContext
  {
    public LembreteContexto(DbContextOptions<LembreteContexto> options)
     : base(options)
    {
    }

    public DbSet<Lembrete> Lembrete { get; set; }
  }
}
