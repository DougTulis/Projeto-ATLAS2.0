using Projeto_ATLAS.Aplicacao.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ATLAS.Aplicacao.Interfaces
{
    public interface ICrud<T>
    {
        public IEnumerable<T> Listar();
        public void Adicionar(T objeto);
        public void Alterar(T objeto);
        public void Excluir(T objeto);
    }
}
