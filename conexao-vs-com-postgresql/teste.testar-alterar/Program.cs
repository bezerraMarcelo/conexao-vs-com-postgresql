using exemplo.dao;
using exemplo.modelo;
using System;

namespace teste.testar_alterar
{
    class Program
    {
        static void Main(string[] args)
        {
            Contato contato = new Contato();

            contato.id = 2;
            contato.nome = "Marcelo Bezerra";
            contato.email = "teste@teste.com.br";

            ContatoDao dao = new ContatoDao();

            dao.Alterar(contato);

            Console.Out.WriteLine("Alterado!");

            Console.ReadKey();
        }
    }
}
