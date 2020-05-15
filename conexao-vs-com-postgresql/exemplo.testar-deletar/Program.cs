using exemplo.dao;
using System;

namespace exemplo.testar_deletar
{
    class Program
    {
        static void Main(string[] args)
        {
            ContatoDao dao = new ContatoDao();

            dao.Deletar(2);

            Console.Out.WriteLine("Deletado!");

            Console.ReadKey();
        }
    }
}
