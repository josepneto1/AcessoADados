using System.Data.SqlClient;
using AcessoADados.Models;
using Dapper.Contrib.Extensions;

namespace AcessoADados.Repositories;

public class ClienteRepository
{
    private readonly SqlConnection _connection;

    public ClienteRepository(SqlConnection connection)
    {
        _connection = connection;
    }

    public IEnumerable<Cliente> BuscarClientes()
        => _connection.GetAll<Cliente>();

    public Cliente BuscarCliente(int id)
        => _connection.Get<Cliente>(id);

    public void CadastrarCliente(Cliente cliente)
        => _connection.Insert<Cliente>(cliente);
}