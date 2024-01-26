using System.Data.SqlClient;
using AcessoADados.Tela.ClienteTela;

const string CONNECTION_STRING = "Server=localhost,1433;Database=Clinica;User ID=sa;Password=Alice1511!";

var connection = new SqlConnection(CONNECTION_STRING);
connection.Open();

CarregarTela();

Console.ReadKey();
connection.Close();

static void CarregarTela()
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
    Console.WriteLine();
    var opcao = short.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            TelaMenuCliente.CarregarTelaMenuCliente();
            break;
        default:
            CarregarTela(); break;
    }
}