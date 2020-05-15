using exemplo.modelo;
using System;
using Npgsql;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace exemplo.dao
{
    public class ContatoDao
    {
        private NpgsqlConnection conexao;

        public ContatoDao()
        {
            this.conexao = new FabricaConexoes().Conexao();
        }
        public void Adicionar(Contato contato)
        {
            conexao.Open();
            try
            {
                string comando = "insert into contatos (nome, email) values (@p1, @p2)";

                using (var cmd = new NpgsqlCommand(comando, conexao))
                {
                    cmd.Parameters.AddWithValue("p1", contato.nome);
                    cmd.Parameters.AddWithValue("p2", contato.email);
                    cmd.ExecuteNonQuery();
                }
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Alterar(Contato contato)
        {
            conexao.Open();
            try
            {
                string comando = "update contatos set nome = @p1, email = @p2 where id = @p3";

                using (var cmd = new NpgsqlCommand(comando, conexao))
                {
                    cmd.Parameters.AddWithValue("p1", contato.nome);
                    cmd.Parameters.AddWithValue("p2", contato.email);
                    cmd.Parameters.AddWithValue("p3", contato.id);
                    cmd.ExecuteNonQuery();
                }
            }
            finally
            {
                conexao.Close();
            }
        }
        public List<Contato> Ler()
        {
            List<Contato> lista =  new List<Contato>();
            string comando = "select * from contatos";

            using (var cmd = new NpgsqlCommand(comando, conexao))
            {
                conexao.Open();
                try
                {
                    var leitura = cmd.ExecuteReader();
                    while (leitura.Read())
                    {
                        Contato contato = new Contato();

                        contato.id = Int32.Parse(leitura["id"].ToString());
                        contato.nome = leitura["nome"].ToString();
                        contato.email = leitura["email"].ToString();

                        lista.Add(contato);
                    }
                }
                finally
                {
                    conexao.Close();
                }
            }
            return lista;
        }
        
     }
}
