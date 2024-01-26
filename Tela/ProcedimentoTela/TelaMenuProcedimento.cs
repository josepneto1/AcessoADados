using AcessoADados.Tela.ClienteTela;

namespace AcessoADados.Tela.ProcedimentoTela;

public static class TelaMenuProcedimento
{
    public static void CarregarTelaMenuProcedimento()
    {
        Console.Clear();
        Console.WriteLine("GESTÃO DE PROCEDIMENTOS");
        Console.WriteLine("-----------------------");
        Console.WriteLine("O que deseja fazer?");
        Console.WriteLine();
        Console.WriteLine("1 - Listar procedimentos");
        Console.WriteLine("2 - Cadastrar procedimento");
        Console.WriteLine("3 - Atualizar procedimento");
        Console.WriteLine("4 - Deletar procedimento");
        Console.WriteLine();
        Console.WriteLine("0 - Voltar");
        Console.WriteLine();
        var opcao = short.Parse(Console.ReadLine()!);

        switch (opcao)
        {
            case 1:
                TelaListarProcedimentos.CarregarTelaListar();
                break;
            case 2:
                TelaCadastrarProcedimento.CarregarTelaCadastrar();
                break;
            case 3:
                TelaAtualizarProcedimento.CarregarTelaAtualizar();
                break;
            case 4:
                TelaDeletarProcedimento.CarregarTelaDeletar();
                break;
            case 0:
                TelaInicial.CarregarTela(); 
                break;
            default: CarregarTelaMenuProcedimento(); break;
        }
    }
}
