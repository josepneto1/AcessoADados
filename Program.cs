using System.Data.SqlClient;
using AcessoADados;
using AcessoADados.Tela;

const string CONNECTION_STRING = "Server=localhost,1433;Database=Clinica;User ID=sa;Password=Alice1511!";

BancoDeDados.Connection = new SqlConnection(CONNECTION_STRING);
BancoDeDados.Connection.Open();

TelaInicial.CarregarTela();

BancoDeDados.Connection.Close();