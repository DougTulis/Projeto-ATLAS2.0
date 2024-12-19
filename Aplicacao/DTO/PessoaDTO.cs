using Projeto_ATLAS.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ATLAS.Aplicacao.DTO
{
    public class PessoaDTO : ModeloAbstrato
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }

        public PessoaDTO(string nome, string telefone, string email, string cpf)
        {
            Nome = nome;
            Telefone = telefone;
            Email = email;
            Cpf = cpf;
        }
        public override string? ToString()
        {
            return "Id: " + Id + "\n" +
                 "Nome: " + Nome + "\n" +
                 "Telefone: " + Telefone + "\n" +
                 "Email: " + Email + "\n" +
                 "Adicionado em: " + DataCriacao;

        }
    }

}
