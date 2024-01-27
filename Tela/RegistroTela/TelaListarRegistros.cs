using AcessoADados.Models;
using AcessoADados.Repositories;

namespace AcessoADados.Tela.RegistroTela;

public static class TelaListarRegistros
{
    public static void CarregarTelaListar()
    {
        Console.Clear();
        Console.WriteLine("Lista de registros");
        Console.WriteLine("------------------------");
        
        Listar();

        Console.WriteLine();
        Console.WriteLine("*Pressione qualquer tecla para voltar");
        Console.ReadKey();
        TelaMenuRegistro.CarregarTelaMenuRegistro();
    }
    
    private static void Listar()
    {
        var repository = new Repository<RegistroProcedimento>();
        var registros = repository.BuscarTodos();

        foreach (var registro in registros)
        {
            Console.WriteLine($"{registro.Id} - ID cliente: {registro.ClienteId} - ID procedimento: {registro.ProcedimentoId} - {registro.DataRealizacao:d} - R$ {registro.Valor}");
        }
    }
}