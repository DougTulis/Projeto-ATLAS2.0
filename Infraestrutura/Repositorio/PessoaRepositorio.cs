using MySql.Data.MySqlClient;
using Projeto_ATLAS.Aplicacao.DTO;
using Projeto_ATLAS.Aplicacao.Interfaces;
using Projeto_ATLAS.Infraestrutura.Servico;
using System;
using System.Collections.Generic;

namespace Projeto_ATLAS.Infraestrutura.Repositorio
{
    internal class PessoaRepositorio : IPessoa
    {
        public void Adicionar(PessoaDTO pessoa)
        {
            // Obtém a conexão com o banco de dados
            using var conexao = new MySqlAdaptadorConexao().ObterConexao();
            
                conexao.Open();

                // Comando SQL para inserir um registro na tabela Pessoa
                string sql = @"
                        INSERT INTO Pessoa (Nome, Telefone, Email, DataCriacao, DataAtualizacao)
                        VALUES (@Nome, @Telefone, @Email, @DataCriacao, @DataAtualizacao)";

                using (var comando = new MySqlCommand(sql, conexao))
                {
                    // Adicionando parâmetros
                    comando.Parameters.AddWithValue("@Nome", pessoa.Nome);
                    comando.Parameters.AddWithValue("@Telefone", pessoa.Telefone);
                    comando.Parameters.AddWithValue("@Email", pessoa.Email);
                    comando.Parameters.AddWithValue("@DataCriacao", DateTime.Now);
                    comando.Parameters.AddWithValue("@DataAtualizacao", DateTime.Now);

                    // Executa o comando SQL
                    comando.ExecuteNonQuery();
                }
            }
        
        public void Alterar(PessoaDTO pessoa)
        {
            throw new NotImplementedException();
        }

        public void Excluir(PessoaDTO pessoa)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PessoaDTO> Listar()
        {
            throw new NotImplementedException();
        }
    }
}
