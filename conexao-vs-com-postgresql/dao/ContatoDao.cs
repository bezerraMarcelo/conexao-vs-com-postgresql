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

        }
    }
}
