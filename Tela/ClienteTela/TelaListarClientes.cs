using AcessoADados.Models;
using AcessoADados.Repositories;

namespace AcessoADados.Tela.ClienteTela;

public static class TelaListarClientes
{
    public static void CarregarTelaListar()
    {
        Console.Clear();
        Console.WriteLine("Lista de clientes");
        Console.WriteLine("------------------------");
        
        Listar();

        Console.WriteLine();
        Console.WriteLine("*Pressione qualquer tecla para voltar");
        Console.ReadKey();
        TelaMenuCliente.CarregarTelaMenuCliente();
    }

    private static void Listar()
    {
        var repository = new Repository<Cliente>();
        var clientes = repository.BuscarTodos();

        foreach (var cliente in clientes)
        {
            Console.WriteLine($"{cliente.Id} - {cliente.Nome} - {cliente.Telefone}");
        }
    }
}