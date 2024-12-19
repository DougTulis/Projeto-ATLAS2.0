using MySql.Data.MySqlClient;
using Projeto_ATLAS.Aplicacao.DTO;
using Projeto_ATLAS.Aplicacao.Interfaces;
using Projeto_ATLAS.Infraestrutura.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ATLAS.Aplicacao.UseCases
{
    public class ListarPessoaUseCase
    {
        private readonly ICrud<PessoaDTO> _pessoaRepositorio;
        public ListarPessoaUseCase(ICrud<PessoaDTO> pessoaRepositorio)
        {
            _pessoaRepositorio = pessoaRepositorio;
        }
        public void Executar()
        {
            try
            {
                foreach (PessoaDTO p in _pessoaRepositorio.Listar())
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("================================");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(p);
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            catch (MySqlException ex) { Console.WriteLine(ex.StackTrace); }
        }
    }
}
