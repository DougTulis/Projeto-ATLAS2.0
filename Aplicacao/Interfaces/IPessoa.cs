using Projeto_ATLAS.Aplicacao.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ATLAS.Aplicacao.Interfaces
{
    interface ICrud<T>
    {
        public IEnumerable<T> Listar();
        public void Adicionar(T objeto);
        public void Alterar(T pessoa);
        public void Excluir(T pessoa);
    }
}
