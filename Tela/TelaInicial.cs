using AcessoADados.Tela.ClienteTela;
using AcessoADados.Tela.ProcedimentoTela;
using AcessoADados.Tela.RegistroTela;

namespace AcessoADados.Tela;

public static class TelaInicial
{
    public static void CarregarTela()
    {
        Console.Clear();
        Console.WriteLine("===== MINHA CLÍNICA =====");
        Console.WriteLine("-------------------------");
        Console.WriteLine("Selecione uma opção:");
        Console.WriteLine();
        Console.WriteLine("1 - Gestão de clientes");
        Console.WriteLine("2 - Gestão de procedimentos");
        Console.WriteLine("3 - Gestão de registros");
        Console.WriteLine();
        var opcao = short.Parse(Console.ReadLine()!);

        switch (opcao)
        {
            case 1:
                TelaMenuCliente.CarregarTelaMenuCliente();
                break;
            case 2:
                TelaMenuProcedimento.CarregarTelaMenuProcedimento();
                break;
            case 3:
                TelaMenuRegistro.CarregarTelaMenuRegistro();
                break;
            default:
                CarregarTela(); break;
        }
    }
}