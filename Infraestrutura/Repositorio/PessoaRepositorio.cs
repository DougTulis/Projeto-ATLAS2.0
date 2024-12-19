using MySql.Data.MySqlClient;
using Projeto_ATLAS.Aplicacao.DTO;
using Projeto_ATLAS.Aplicacao.Interfaces;
using Projeto_ATLAS.Dominio.Entidades;
using Projeto_ATLAS.Infraestrutura.Servico;
using System;
using System.Collections.Generic;

namespace Projeto_ATLAS.Infraestrutura.Repositorio
{
    internal class PessoaRepositorio : ICrud<PessoaDTO>
    {
        public void Adicionar(PessoaDTO pessoa)
        {

            // Obtém a conexão com o banco de dados
            using var conexao = new MySqlAdaptadorConexao().ObterConexao();
            conexao.Open();

            // Comando SQL para inserir um registro na tabela Pessoa
            string sql = @"
                        INSERT INTO Pessoa (Nome, Telefone, Email, DataCriacao, DataAtualizacao,Cpf)
                        VALUES (@Nome, @Telefone, @Email, @DataCriacao, @DataAtualizacao, @Cpf)";

            using (var comando = new MySqlCommand(sql, conexao))
            {
                // Adicionando parâmetros
                comando.Parameters.AddWithValue("@Nome", pessoa.Nome);
                comando.Parameters.AddWithValue("@Telefone", pessoa.Telefone);
                comando.Parameters.AddWithValue("@Email", pessoa.Email);
                comando.Parameters.AddWithValue("@DataCriacao", DateTime.Now);
                comando.Parameters.AddWithValue("@DataAtualizacao", DateTime.Now);
                comando.Parameters.AddWithValue("@Cpf", pessoa.Cpf);

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
            using var conexao = new MySqlAdaptadorConexao().ObterConexao();
            conexao.Open();
            var Lista = new List<PessoaDTO>();
            string Sql = "SELECT * FROM Pessoa";
            var Cmd = new MySqlCommand(Sql, conexao);
            using MySqlDataReader dataReader = Cmd.ExecuteReader();
            while (dataReader.Read())
            {
                int id = Convert.ToInt32(dataReader["Id"]);
                string nome = Convert.ToString(dataReader["Nome"]);
                string telefone = Convert.ToString(dataReader["Telefone"]);
                string email = Convert.ToString(dataReader["Email"]);
                string cpf = Convert.ToString(dataReader["Cpf"]);
                DateTime dataCriacao = Convert.ToDateTime(dataReader["DataCriacao"]);
                var pessoaDTO = new PessoaDTO(nome, telefone, email, cpf)
                {
                    Id = id, DataCriacao = dataCriacao

                };
                
                Lista.Add(pessoaDTO);
            }
            return Lista;

        }
    }
}
