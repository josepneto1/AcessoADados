using AcessoADados.Models;
using AcessoADados.Repositories;
using AcessoADados.Tela.ClienteTela;

namespace AcessoADados.Tela.ProcedimentoTela;

public static class TelaCadastrarProcedimento
{
    public static void CarregarTelaCadastrar()
    {
        Console.Clear();
        Console.WriteLine("Cadastrar procedimento");
        Console.WriteLine("------------------------");
        Console.Write("Nome: ");
        var nome = Console.ReadLine();
        
        Console.Write("Valor: ");
        var valor = Console.ReadLine();
        
        Cadastrar(new Procedimento
        {
            Nome = nome,
            Valor = double.Parse(valor),
        });
        
        Console.WriteLine();
        Console.WriteLine("*Pressione qualquer tecla para voltar");
        Console.ReadKey();
        TelaMenuProcedimento.CarregarTelaMenuProcedimento();
    }
    
    public static void Cadastrar(Procedimento procedimento)
    {
        try
        {
            var repository = new Repository<Procedimento>();
            repository.Cadastrar(procedimento);
            Console.WriteLine("Cadastro concluído");
        }
        catch (Exception e)
        {
            Console.WriteLine("Não foi possível cadastrar o procedimento");
            Console.WriteLine(e.Message);
        }
    }
}