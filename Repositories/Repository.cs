using System.Data.SqlClient;
using AcessoADados.Models;
using Dapper.Contrib.Extensions;

namespace AcessoADados.Repositories;

public class Repository<T> where T : class
{
    private readonly SqlConnection _connection;

    public Repository(SqlConnection connection)
    {
        _connection = connection;
    }
    
    public IEnumerable<T> BuscarTodos()
        => _connection.GetAll<T>();
    
    public Procedimento BuscarUmo(int id)
        => _connection.Get<Procedimento>(id);

    public void CadastrarProcedimento(Procedimento procedimento)
        => _connection.Insert<Procedimento>(procedimento);
    
    public void AtualizarProcedimento(Procedimento procedimento)
    {
        if (procedimento.Id != 0)
        {
            _connection.Update<Procedimento>(procedimento);
        }
    }
    
    public void DeletarProcedimento(Procedimento procedimento)
    {
        if (procedimento.Id != 0)
        {
            _connection.Delete<Procedimento>(procedimento);
        }
    }
    
    public void DeletarProcedimento(int id)
    {
        if (id != 0)
        {
            return;
        }

        var procedimento = _connection.Get<Procedimento>(id);
        _connection.Delete<Procedimento>(procedimento);
    }
}