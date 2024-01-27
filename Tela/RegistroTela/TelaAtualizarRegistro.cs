using AcessoADados.Models;
using AcessoADados.Repositories;

namespace AcessoADados.Tela.RegistroTela;

public static class TelaAtualizarRegistro
{
    public static void CarregarTelaAtualizar()
    {
        Console.Clear();
        Console.WriteLine("Atualizar registro");
        Console.WriteLine("------------------------");
        Console.Write("ID do registro: ");
        var id = Console.ReadLine();
        
        Console.Write("ID do cliente: ");
        var idCliente = Console.ReadLine();
        
        Console.Write("ID do procedimento: ");
        var idProcedimento = Console.ReadLine();
        
        Console.Write("Data do procedimento: ");
        var dataString = Console.ReadLine();
        DateTime data;
        DateTime.TryParse(dataString, null, out data);
        
        Console.Write("Valor: ");
        var valor = Console.ReadLine();
        
        Atualizar(new RegistroProcedimento
        {
            Id = int.Parse(id),
            ClienteId = int.Parse(idCliente),
            ProcedimentoId = int.Parse(idProcedimento),
            DataRealizacao = data,
            Valor = double.Parse(valor)
        });
        
        Console.WriteLine();
        Console.WriteLine("*Pressione qualquer tecla para voltar");
        Console.ReadKey();
        TelaMenuRegistro.CarregarTelaMenuRegistro();
    }
    
    public static void Atualizar(RegistroProcedimento registro)
    {
        try
        {
            var repository = new Repository<RegistroProcedimento>();
            repository.Atualizar(registro);
            Console.WriteLine("Atualização concluída");
        }
        catch (Exception e)
        {
            Console.WriteLine("Não foi possível atualizar o registro");
            Console.WriteLine(e.Message);
        }
    }
}