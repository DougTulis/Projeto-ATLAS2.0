using Projeto_ATLAS.Aplicacao.DTO;
using Projeto_ATLAS.Aplicacao.Interfaces;
using Projeto_ATLAS.Aplicacao.UseCases;
using Projeto_ATLAS.Infraestrutura.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ATLAS.Aplicacao.Menus
{
    public class CadastroPessoas 
    {
        public static void Cadastrar()
        {
            Console.Clear();
            Console.Write("Digite o nome completo: ");
            string nome = Console.ReadLine();
            Console.Write("Telefone: ");
            string telefone = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Cpf: ");
            string cpf = Console.ReadLine();
            PessoaDTO pessoaDto = new PessoaDTO(nome,telefone,email,cpf);

            var repositorioPessoa = new PessoaRepositorio();
            var useCase = new CriarPessoaUseCase(repositorioPessoa);

            useCase.Executar(pessoaDto);
            Console.WriteLine("Pessoa registrada com sucesso! Voltando ao menu principal....");
            Thread.Sleep(2500);
            Console.Clear();
            MenuPrincipal.ExibirEExecutar();
        }

    }
}
