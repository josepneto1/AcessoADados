using System.Data.SqlClient;
using AcessoADados.Models;
using AcessoADados.Repositories;
using Dapper.Contrib.Extensions;

const string CONNECTION_STRING = "Server=localhost,1433;Database=Clinica;User ID=sa;Password=Alice1511!";

var connection = new SqlConnection(CONNECTION_STRING);
connection.Open();

MostrarClientes();
// MostrarCliente();
// CadastrarCliente();
// AtualizarCliente();
// DeletarCliente();

connection.Close();

static void MostrarClientes(SqlConnection connection)
{
    var repository = new ClienteRepository(connection);
    var clientes = repository.BuscarClientes();

    foreach (var cliente in clientes)
    {
        Console.WriteLine(cliente.Nome);
    }
}

static void MostrarCliente()
{
    using (var connection = new SqlConnection(CONNECTION_STRING))
    {
        var cliente = connection.Get<Cliente>(1);
        Console.WriteLine(cliente.Nome);
    }
}

static void CadastrarCliente()
{
    var cliente = new Cliente()
    {
        Nome = "Alice Melchior",
        Telefone = "43984110033",
        Detalhe = "nda"
    };

    using (var connection = new SqlConnection(CONNECTION_STRING))
    {
        connection.Insert<Cliente>(cliente);
        Console.WriteLine($"Cliente {cliente.Nome} cadastrado(a) com sucesso");
    }
}

static void AtualizarCliente()
{
    var cliente = new Cliente()
    {
        Id = 2,
        Nome = "Alice M P",
        Telefone = "43984110033",
        Detalhe = "nda"
    };

    using (var connection = new SqlConnection(CONNECTION_STRING))
    {
        connection.Update<Cliente>(cliente);
        Console.WriteLine($"Atualização de {cliente.Nome} realizada");
    }
}

static void DeletarCliente()
{
    using (var connection = new SqlConnection(CONNECTION_STRING))
    {
        var cliente = connection.Get<Cliente>(2);
        connection.Delete<Cliente>(cliente);
        Console.WriteLine($"{cliente.Nome} deletado(a)");
    }
}