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
    {
        cliente.Id = 0; // atribui sempre o valor 0 para o id de um cliente, não atrapalha o incremento do db
        _connection.Insert<Cliente>(cliente); 
    }

    public void AtualizarCliente(Cliente cliente)
    {
        if (cliente.Id != 0)
        {
            _connection.Update<Cliente>(cliente);
        }
    }
    
    public void DeletarCliente(Cliente cliente)
    {
        if (cliente.Id != 0)
        {
            _connection.Delete<Cliente>(cliente);
        }
    }
    
    public void DeletarCliente(int id)
    {
        if (id != 0)
        {
            return;
        }

        var cliente = _connection.Get<Cliente>(id);
        _connection.Delete<Cliente>(cliente);
    }
}