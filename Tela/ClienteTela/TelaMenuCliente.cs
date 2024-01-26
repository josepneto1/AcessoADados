namespace AcessoADados.Tela.ClienteTela;

public static class TelaMenuCliente
{
    public static void CarregarTelaMenuCliente()
    {
        Console.Clear();
        Console.WriteLine("== GESTÃO DE CLIENTES ==");
        Console.WriteLine("------------------------");
        Console.WriteLine("O que deseja fazer?");
        Console.WriteLine();
        Console.WriteLine("1 - Listar clientes");
        Console.WriteLine("2 - Cadastrar cliente");
        Console.WriteLine("3 - Atualizar cliente");
        Console.WriteLine("4 - Deletar cliente");
        Console.WriteLine();
        Console.WriteLine("0 - Voltar");
        Console.WriteLine();
        var opcao = short.Parse(Console.ReadLine()!);

        switch (opcao)
        {
            case 1:
                TelaListarClientes.CarregarTelaListar();
                break;
            case 2:
                TelaCadastrarCliente.CarregarTelaCadastrar();
                break;
            case 3:
                TelaAtualizarCliente.CarregarTelaAtualizar();
                break;
            case 4:
                TelaDeletarCliente.CarregarTelaDeletar();
                break;
            case 0:
                TelaInicial.CarregarTela(); 
                break;
            default: CarregarTelaMenuCliente(); break;
        }
    }
}