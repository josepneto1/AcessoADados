using System.ComponentModel.DataAnnotations.Schema;

namespace AcessoADados.Models;

[Table("[RegistroProcedimento]")]
public class RegistroProcedimento
{
    public int Id { get; set; }
    public int ClienteId { get; set; }
    public int ProcedimentoId { get; set; }
    public DateTime DataRealizacao { get; set; }
    public double Valor { get; set; }
}