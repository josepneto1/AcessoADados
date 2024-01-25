using System.Data.SqlClient;
using AcessoADados.Models;
using AcessoADados.Repositories;
using Dapper.Contrib.Extensions;

const string CONNECTION_STRING = "Server=localhost,1433;Database=Clinica;User ID=sa;Password=Alice1511!";

var connection = new SqlConnection(CONNECTION_STRING);
connection.Open();

MostrarClientes(connection);
MostrarProcedimentos(connection);
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

static void MostrarProcedimentos(SqlConnection connection)
{
    var repository = new ProcedimentoRepository(connection);
    var procedimentos = repository.BuscarProcedimentos();

    foreach (var procedimento in procedimentos)
    {
        Console.WriteLine(procedimento.Nome);
    }

}