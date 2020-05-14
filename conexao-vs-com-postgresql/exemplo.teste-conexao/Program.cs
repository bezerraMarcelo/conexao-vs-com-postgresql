using Npgsql;
using System;

namespace exemplo.teste_conexao
{
    class Program
    {
        static void Main(string[] args)
        {
            NpgsqlConnection conexao = new FabricaConexoes().Conexao();
            Console.WriteLine("Conexão aberta!");
            conexao.Close();
            Console.ReadKey();
        }
    }
}
