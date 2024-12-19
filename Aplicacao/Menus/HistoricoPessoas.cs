using Projeto_ATLAS.Aplicacao.UseCases;
using Projeto_ATLAS.Infraestrutura.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ATLAS.Aplicacao.Menus
{
    public class HistoricoPessoas
    {
        public static void Exibir()
        {
            Console.Clear();
            var pessoaRepositorio = new PessoaRepositorio();
            var useCase = new ListarPessoaUseCase(pessoaRepositorio);
            useCase.Executar();
            Console.WriteLine("Digite qualquer tecla para voltar ao menu principal: ");
            Console.ReadKey();
            Console.Clear();
            MenuPrincipal.ExibirEExecutar();
        }
    }
}
