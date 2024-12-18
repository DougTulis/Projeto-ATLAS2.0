using Projeto_ATLAS.Aplicacao.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ATLAS.Aplicacao.Interfaces
{
    interface IPessoa
    {
        public IEnumerable<PessoaDTO> Listar();
        public void Adicionar(PessoaDTO pessoa);
        public void Alterar(PessoaDTO pessoa);
        public void Excluir(PessoaDTO pessoa);
    }
}
