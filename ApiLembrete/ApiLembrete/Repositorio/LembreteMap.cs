using ApiLembrete.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace ApiLembrete.Repositorio
{
  public class LembreteMap : EntityTypeConfiguration<Lembrete>
  {
    public LembreteMap()
    {
      HasKey(l => l.Id);
    }

    public static LembreteMap Create() => new LembreteMap();
  }
}
