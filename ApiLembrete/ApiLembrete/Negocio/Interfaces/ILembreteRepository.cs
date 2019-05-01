using ApiLembrete.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiLembrete.Negocio.Interfaces
{
  public interface ILembreteRepository
  {
    void Add(Lembrete lembrete);
    IList<Lembrete> Get();
    Lembrete GetById(int id);
    void Update(Lembrete lembrete);
    void Delete(int id);
  }
}
