using System.Data.SqlClient;
using Dapper.Contrib.Extensions;

namespace AcessoADados.Repositories;

public class Repository<T> where T : class
{ 
    public IEnumerable<T> BuscarTodos()
        => BancoDeDados.Connection.GetAll<T>();
    
    public T BuscarUm(int id)
        => BancoDeDados.Connection.Get<T>(id);

    public void Cadastrar(T model)
        => BancoDeDados.Connection.Insert<T>(model );
    
    public void Atualizar(T model)
        => BancoDeDados.Connection.Update<T>(model);
    
    public void Deletar(T model)
        => BancoDeDados.Connection.Delete<T>(model);

    public void Deletar(int id)
    {
        var model = BancoDeDados.Connection.Get<T>(id);
        BancoDeDados.Connection.Delete<T>(model);
        
    }

}