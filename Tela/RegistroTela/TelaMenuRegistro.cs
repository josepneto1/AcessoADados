namespace AcessoADados.Tela.RegistroTela;

public static class TelaMenuRegistro
{
    public static void CarregarTelaMenuRegistro()
    {
        Console.Clear();
        Console.WriteLine("= GESTÃO DE REGISTROS =");
        Console.WriteLine("-----------------------");
        Console.WriteLine("O que deseja fazer?");
        Console.WriteLine();
        Console.WriteLine("1 - Listar registros");
        Console.WriteLine("2 - Adicionar registro");
        Console.WriteLine("3 - Atualizar registro");
        Console.WriteLine("4 - Deletar registro");
        Console.WriteLine();
        Console.WriteLine("0 - Voltar");
        Console.WriteLine();
        var opcao = short.Parse(Console.ReadLine()!);

        switch (opcao)
        {
            case 1:
                TelaListarRegistros.CarregarTelaListar();
                break;
            case 2:
                TelaCadastrarRegistro.CarregarTelaCadastrar();
                break;
            case 3:
                TelaAtualizarRegistro.CarregarTelaAtualizar();
                break;
            case 4:
                TelaDeletarRegistro.CarregarTelaDeletar();
                break;
            case 0:
                TelaInicial.CarregarTela(); 
                break;
            default: CarregarTelaMenuRegistro(); break;
        }
    }
}