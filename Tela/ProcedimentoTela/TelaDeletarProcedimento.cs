using AcessoADados.Models;
using AcessoADados.Repositories;

namespace AcessoADados.Tela.ProcedimentoTela;

public static class TelaDeletarProcedimento
{
    public static void CarregarTelaDeletar()
    {
        Console.Clear();
        Console.WriteLine("Deletar procedimento");
        Console.WriteLine("------------------------");
        Console.Write("Informe o ID do procedimento que deseja deletar: ");
        var id = Console.ReadLine();
    
        Deletar(int.Parse(id));
    
        Console.WriteLine();
        Console.WriteLine("*Pressione qualquer tecla para voltar");
        Console.ReadKey();
        TelaMenuProcedimento.CarregarTelaMenuProcedimento();
    }
    
    public static void Deletar(int id)
    {
        try
        {
            var repository = new Repository<Procedimento>();
            repository.Deletar(id);
            Console.WriteLine("Exclusão concluída");
        }
        catch (Exception e)
        {
            Console.WriteLine("Não foi possível excluir o procedimento");
            Console.WriteLine(e.Message);
        }
    }
}