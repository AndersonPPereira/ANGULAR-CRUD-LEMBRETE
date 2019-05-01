using System.Collections.Generic;
using System.Linq;
using ApiLembrete.Entidades;
using ApiLembrete.Enumerador;
using ApiLembrete.Negocio.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ApiLembrete.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class LembreteController : ControllerBase
  {
    private readonly ILembreteRepository _lembreteRepository;

    public LembreteController(ILembreteRepository lembreteRepository)
    {
      _lembreteRepository = lembreteRepository;
    }

    // GET api/values
    public ActionResult<IList<Lembrete>> Get()
    {

      return _lembreteRepository.Get().ToList();

      //return new List<Lembrete>
      //{
      //  new Lembrete{Id = 1, Conteudo = "Reunião na Consinco", Arquivado = false, Modificado = 1, Prioridade = Prioridade.ALTA},
      //  new Lembrete{Id = 2, Conteudo = "Reunião na Linx", Arquivado = false, Modificado = 1, Prioridade = Prioridade.BAIXA}
      //};
    }

    // GET api/values/5
    [HttpGet("{id}")]
    public ActionResult<Lembrete> Get(int id)
    {
      return _lembreteRepository.GetById(id);
    }

    // POST api/values
    [HttpPost]
    public void Post([FromBody] Lembrete lembrete)
    {
      _lembreteRepository.Add(lembrete);
    }

    // PUT api/values/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Lembrete lembrete)
    {
      _lembreteRepository.Update(lembrete);
    }

    // DELETE api/values/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      _lembreteRepository.Delete(id);
    }
  }
}
