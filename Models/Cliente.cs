using Dapper.Contrib.Extensions;

namespace AcessoADados.Models;

[Table("[Cliente]")]
public class Cliente
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Telefone { get; set; }
    public string Detalhe { get; set; }
}