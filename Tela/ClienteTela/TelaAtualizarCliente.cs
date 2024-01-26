using AcessoADados.Models;
using AcessoADados.Repositories;

namespace AcessoADados.Tela.ClienteTela;

public static class TelaAtualizarCliente
{
    public static void CarregarTelaAtualizar()
    {
        Console.Clear();
        Console.WriteLine("Atualizar cliente");
        Console.WriteLine("------------------------");
        Console.Write("ID: ");
        var id = Console.ReadLine();
        
        Console.Write("Nome: ");
        var nome = Console.ReadLine();
        
        Console.Write("Telefone: ");
        var telefone = Console.ReadLine();
        
        Console.Write("Detalhe: ");
        var detalhe = Console.ReadLine();
        
        Atualizar(new Cliente
        {
            Id = int.Parse(id),
            Nome = nome,
            Telefone = telefone,
            Detalhe = detalhe,
        });
        
        Console.WriteLine();
        Console.WriteLine("*Pressione qualquer tecla para voltar");
        Console.ReadKey();
        TelaMenuCliente.CarregarTelaMenuCliente();
    }
    
    public static void Atualizar(Cliente cliente)
    {
        try
        {
            var repository = new Repository<Cliente>();
            repository.Atualizar(cliente);
            Console.WriteLine("Atualização concluída");
        }
        catch (Exception e)
        {
            Console.WriteLine("Não foi possível atualizar o cliente");
            Console.WriteLine(e.Message);
        }
    }
}