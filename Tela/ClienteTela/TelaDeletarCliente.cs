using AcessoADados.Models;
using AcessoADados.Repositories;

namespace AcessoADados.Tela.ClienteTela;

public static class TelaDeletarCliente
{
    public static void CarregarTelaDeletar()
    {
        Console.Clear();
        Console.WriteLine("Deletar cliente");
        Console.WriteLine("------------------------");
        Console.Write("Informe o ID do cliente que deseja deletar: ");
        var id = Console.ReadLine();
    
        Deletar(int.Parse(id));
    
        Console.WriteLine();
        Console.WriteLine("*Pressione qualquer tecla para voltar");
        Console.ReadKey();
        TelaMenuCliente.CarregarTelaMenuCliente();
    }
    
    public static void Deletar(int id)
    {
        try
        {
            var repository = new Repository<Cliente>();
            repository.Deletar(id);
            Console.WriteLine("Exclusão concluída");
        }
        catch (Exception e)
        {
            Console.WriteLine("Não foi possível excluir o cliente");
            Console.WriteLine(e.Message);
        }
    }
}