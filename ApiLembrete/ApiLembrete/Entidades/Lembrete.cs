using ApiLembrete.Enumerador;

namespace ApiLembrete.Entidades
{
  public class Lembrete
  {
    public int Id { get; set; }
    public string Conteudo { get; set; }
    public bool Arquivado { get; set; }
    public Prioridade Prioridade { get; set; }
    public int Modificado { get; set; }
  }
}
