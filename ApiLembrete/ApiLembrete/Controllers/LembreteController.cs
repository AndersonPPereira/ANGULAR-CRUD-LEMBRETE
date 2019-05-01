using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiLembrete.Entidades;
using ApiLembrete.Enumerador;
using Microsoft.AspNetCore.Mvc;

namespace ApiLembrete.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class LembreteController : ControllerBase
  {
    // GET api/values
    public ActionResult<IList<Lembrete>> Get()
    {
      return new List<Lembrete>
      {
        new Lembrete{Id = 1, Conteudo = "Reunião na Consinco", Arquivado = false, Modificado = 1, Prioridade = Prioridade.ALTA},
        new Lembrete{Id = 2, Conteudo = "Reunião na Linx", Arquivado = false, Modificado = 1, Prioridade = Prioridade.BAIXA}
      };
    }

    // GET api/values/5
    [HttpGet("{id}")]
    public ActionResult<Lembrete> Get(int id)
    {
      return new Lembrete { Id = 2, Conteudo = "Reunião na Linx", Arquivado = false, Modificado = 1, Prioridade = Prioridade.BAIXA };
    }

    // POST api/values
    [HttpPost]
    public void Post([FromBody] string value)
    {
    }

    // PUT api/values/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/values/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
  }
}
