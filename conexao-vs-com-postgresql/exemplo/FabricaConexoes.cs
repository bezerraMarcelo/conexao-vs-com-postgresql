﻿using Npgsql;
using System;

namespace exemplo
{
    public class FabricaConexoes
    {
        public NpgsqlConnection Conexao()
        {
            try
            {
                string stringConexao = "server=localhost;port=5432;user id=postgres;password=root;database=Cliente";
                return new NpgsqlConnection(stringConexao);
            } catch (Exception e)
            {
                throw new System.ArgumentException("Erro ao conectar ao banco de dados " + e.Message);                
            }
            
        }
    }
}
