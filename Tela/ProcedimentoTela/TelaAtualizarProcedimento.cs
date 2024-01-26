using AcessoADados.Models;
using AcessoADados.Repositories;

namespace AcessoADados.Tela.ProcedimentoTela;

public static class TelaAtualizarProcedimento
{
    public static void CarregarTelaAtualizar()
    {
        Console.Clear();
        Console.WriteLine("Atualizar procedimento");
        Console.WriteLine("------------------------");
        Console.Write("ID: ");
        var id = Console.ReadLine();
        
        Console.Write("Nome: ");
        var nome = Console.ReadLine();
        
        Console.Write("Valor: ");
        var valor = Console.ReadLine();
        
        Atualizar(new Procedimento
        {
            Id = int.Parse(id),
            Nome = nome,
            Valor = double.Parse(valor),
        });
        
        Console.WriteLine();
        Console.WriteLine("*Pressione qualquer tecla para voltar");
        Console.ReadKey();
        TelaMenuProcedimento.CarregarTelaMenuProcedimento();
    }
    
    public static void Atualizar(Procedimento procedimento)
    {
        try
        {
            var repository = new Repository<Procedimento>();
            repository.Atualizar(procedimento);
            Console.WriteLine("Atualização concluída");
        }
        catch (Exception e)
        {
            Console.WriteLine("Não foi possível atualizar o procedimento");
            Console.WriteLine(e.Message);
        }
    }
}