using AcessoADados.Models;
using AcessoADados.Repositories;

namespace AcessoADados.Tela.ProcedimentoTela;

public static class TelaListarProcedimentos
{
    public static void CarregarTelaListar()
    {
        Console.Clear();
        Console.WriteLine("Lista de procedimentos");
        Console.WriteLine("------------------------");
        
        Listar();

        Console.WriteLine();
        Console.WriteLine("*Pressione qualquer tecla para voltar");
        Console.ReadKey();
        TelaMenuProcedimento.CarregarTelaMenuProcedimento();
    }
    
    private static void Listar()
    {
        var repository = new Repository<Procedimento>();
        var procedimentos = repository.BuscarTodos();

        foreach (var procedimento in procedimentos)
        {
            Console.WriteLine($"{procedimento.Id} - {procedimento.Nome} - R$ {procedimento.Valor}");
        }
    }
}