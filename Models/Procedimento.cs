using System.ComponentModel.DataAnnotations.Schema;

namespace AcessoADados.Models;

[Table("[Procedimento]")]
public class Procedimento
{
    public int Id { get; set; } 
    public string Nome { get; set; }
    public double Valor { get; set; }
}