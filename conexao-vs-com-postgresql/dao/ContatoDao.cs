using exemplo.modelo;
using System;
using Npgsql;

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
    }
}
