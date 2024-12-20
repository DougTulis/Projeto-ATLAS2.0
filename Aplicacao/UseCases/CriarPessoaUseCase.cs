using Projeto_ATLAS.Aplicacao.DTO;
using Projeto_ATLAS.Aplicacao.Interfaces;
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

        private readonly IConexao _conexao;
        private readonly ICrud<PessoaDTO> _pessoa;

        public CriarPessoaUseCase(IConexao conexao)
        {
            _conexao = conexao;
        }

        public void Executar(PessoaDTO pessoa)
        {
         
        }

    }
}
