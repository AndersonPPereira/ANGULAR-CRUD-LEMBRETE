using ApiLembrete.Entidades;
using ApiLembrete.Negocio.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace ApiLembrete.Repositorio
{
  public class LembreteRepository : ILembreteRepository
  {
    private readonly LembreteContexto contexto;

    public LembreteRepository(LembreteContexto context)
    {
      contexto = context;
    }

    public void Add(Lembrete lembrete)
    {
      contexto.Lembrete.Add(lembrete);
      contexto.SaveChanges();
    }

    public IList<Lembrete> Get()
    {
      return contexto.Lembrete.ToList();
    }

    public Lembrete GetById(int id)
    {
      return contexto.Lembrete.FirstOrDefault(l => l.Id == id);
    }

    public void Update(Lembrete lembrete)
    {
      contexto.Entry(lembrete).State = EntityState.Modified;
      contexto.SaveChanges();
    }

    public void Delete(int id)
    {
      var lembrete = contexto.Lembrete.FirstOrDefault(l => l.Id == id);

      if (lembrete != null)
      {
        contexto.Lembrete.Remove(lembrete);
        contexto.SaveChanges();
      }
    }
  }
}
