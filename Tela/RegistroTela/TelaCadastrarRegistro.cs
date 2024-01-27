using AcessoADados.Models;
using AcessoADados.Repositories;

namespace AcessoADados.Tela.RegistroTela;

public static class TelaCadastrarRegistro
{
    public static void CarregarTelaCadastrar()
    {
        Console.Clear();
        Console.WriteLine("Adicionar registro");
        Console.WriteLine("------------------------");
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
        
        Cadastrar(new RegistroProcedimento
        {
            ClienteId = int.Parse(idCliente),
            ProcedimentoId = int.Parse(idProcedimento),
            DataRealizacao = data,
            Valor = double.Parse(valor),
        });
        
        Console.WriteLine();
        Console.WriteLine("*Pressione qualquer tecla para voltar");
        Console.ReadKey();
        TelaMenuRegistro.CarregarTelaMenuRegistro();
    }
    
    public static void Cadastrar(RegistroProcedimento registro)
    {
        try
        {
            var repository = new Repository<RegistroProcedimento>();
            repository.Cadastrar(registro);
            Console.WriteLine("Registro concluído");
        }
        catch (Exception e)
        {
            Console.WriteLine("Não foi possível fazer o registro");
            Console.WriteLine(e.Message);
        }
    }
}