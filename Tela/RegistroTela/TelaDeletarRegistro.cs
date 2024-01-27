using AcessoADados.Models;
using AcessoADados.Repositories;

namespace AcessoADados.Tela.RegistroTela;

public static class TelaDeletarRegistro
{
    public static void CarregarTelaDeletar()
    {
        Console.Clear();
        Console.WriteLine("Deletar registro");
        Console.WriteLine("------------------------");
        Console.Write("Informe o ID do registro que deseja deletar: ");
        var id = Console.ReadLine();
    
        Deletar(int.Parse(id));
    
        Console.WriteLine();
        Console.WriteLine("*Pressione qualquer tecla para voltar");
        Console.ReadKey();
        TelaMenuRegistro.CarregarTelaMenuRegistro();
    }

    public static void Deletar(int id)
    {
        try
        {
            var repository = new Repository<RegistroProcedimento>();
            repository.Deletar(id);
            Console.WriteLine("Exclusão concluída");
        }
        catch (Exception e)
        {
            Console.WriteLine("Não foi possível excluir o registro");
            Console.WriteLine(e.Message);
        }
    }
}