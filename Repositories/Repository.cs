using System.Data.SqlClient;
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
    
    public T BuscarUm(int id)
        => _connection.Get<T>(id);

    public void Cadastrar(T model)
        => _connection.Insert<T>(model );
    
    public void Atualizar(T model)
        => _connection.Update<T>(model);
    
    public void Deletar(T model)
        => _connection.Delete<T>(model);

    public void Deletar(int id)
    {
        var model = _connection.Get<T>(id);
        _connection.Delete<T>(model);
        
    }

}