using Npgsql;
using System;

namespace exemplo.teste_conexao
{
    class Program
    {
        static void Main(string[] args)
        {
            NpgsqlConnection con = new FabricaConexoes().conexao();
            Console.WriteLine("Conexão aberta!");
            con.Close();
            Console.ReadKey();
        }
    }
}
