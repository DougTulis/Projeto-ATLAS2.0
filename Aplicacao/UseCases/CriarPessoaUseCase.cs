using MySql.Data.MySqlClient;
using Projeto_ATLAS.Aplicacao.DTO;
using Projeto_ATLAS.Aplicacao.Interfaces;
using Projeto_ATLAS.Infraestrutura.Repositorio;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ATLAS.Aplicacao.UseCases
{
    public class CriarPessoaUseCase
    {

        private readonly ICrud<PessoaDTO> _pessoaRepositorio;

        public CriarPessoaUseCase(ICrud<PessoaDTO> pessoaRepositorio)
        {
            _pessoaRepositorio = pessoaRepositorio;
        }
        public void Executar(PessoaDTO pessoa)
        {
            try {
                _pessoaRepositorio.Adicionar(pessoa);
            } catch(MySqlException e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
