using AcessoADados.Models;
using AcessoADados.Repositories;

namespace AcessoADados.Tela.ClienteTela;

public static class TelaCadastrarCliente
{
    public static void CarregarTelaCadastrar()
    {
        Console.Clear();
        Console.WriteLine("Cadastrar cliente");
        Console.WriteLine("------------------------");
        Console.Write("Nome: ");
        var nome = Console.ReadLine();
        
        Console.Write("Telefone: ");
        var telefone = Console.ReadLine();
        
        Console.Write("Detalhe: ");
        var detalhe = Console.ReadLine();
        
        Cadastrar(new Cliente
        {
            Nome = nome,
            Telefone = telefone,
            Detalhe = detalhe,
        });
        
        Console.WriteLine();
        Console.WriteLine("*Pressione qualquer tecla para voltar");
        Console.ReadKey();
        TelaMenuCliente.CarregarTelaMenuCliente();
    }
    
    public static void Cadastrar(Cliente cliente)
    {
        try
        {
            var repository = new Repository<Cliente>();
            repository.Cadastrar(cliente);
            Console.WriteLine("Cadastro concluído");
        }
        catch (Exception e)
        {
            Console.WriteLine("Não foi possível cadastrar o cliente");
            Console.WriteLine(e.Message);
        }
    }
}