using exemplo.dao;
using exemplo.modelo;
using System;

namespace exemplo.teste_adiciona
{
    class Program
    {
        static void Main(string[] args)
        {
            Contato contato = new Contato();

            contato.nome = "Marcelo2";
            contato.email = "teste@teste.com.br";

            ContatoDao dao = new ContatoDao();

            dao.Adicionar(contato);

            Console.Out.WriteLine("Gravado!");

            Console.ReadKey();
        }
    }
}
