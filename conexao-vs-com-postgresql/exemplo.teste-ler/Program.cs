using exemplo.dao;
using exemplo.modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace exemplo.teste_ler
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Contato> contatos;
                        
            ContatoDao dao = new ContatoDao();

            contatos = dao.Ler();

            foreach(Contato contato in contatos)
            {
                Console.Out.WriteLine(contato.nome);
            }

            Console.ReadKey();
        }
    }
}
