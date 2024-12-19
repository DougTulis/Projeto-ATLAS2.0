using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ATLAS.Aplicacao.Menus
{
    public class MenuPrincipal
    {
        static void ExibirLogo()
        {
            Console.WriteLine(@"             █████  ████████ ██       █████  ███████             
▄ ██ ▄▄ ██ ▄██   ██    ██    ██      ██   ██ ██      ▄ ██ ▄▄ ██ ▄
 ████  ████ ███████    ██    ██      ███████ ███████  ████  ████ 
▀ ██ ▀▀ ██ ▀██   ██    ██    ██      ██   ██      ██ ▀ ██ ▀▀ ██ ▀
            ██   ██    ██    ███████ ██   ██ ███████             
                                                                 
                                                               ");
        }

        public static void ExibirEExecutar()
        {
            ExibirLogo();
            Console.WriteLine();
            Console.WriteLine("Escolha uma opção: ");
            Console.WriteLine("1. Registrar Pessoa");
            Console.WriteLine("2. Histórico de pessoas");
            Console.WriteLine("3. Nova Locação");
            Console.WriteLine("4. Historico de Locação");
            Console.WriteLine("5. Baixar Locação");
            Console.WriteLine("6. Plano de Contas");
            Console.WriteLine("7. Listar Pendencias Financeiras");
            Console.WriteLine("8. Baixar Pendência Financeira");
            Console.WriteLine("0. Sair");
            Console.Write("Escolha uma opção: ");
            int Escolha = int.Parse(Console.ReadLine());
            switch (Escolha)
            {
                case 1:
                    CadastroPessoas.Cadastrar();
                    break;
                case 2:
                    HistoricoPessoas.Exibir();
                    break;
                case 3:
                    // Metodo
                    break;
                case 4:
                    // Metodo
                    break;
                case 5:
                    // Metodo
                    break;
                case 6:
                    // Metodo
                    break;
                case 7:
                    // Metodo
                    break;
                case 8:
                    // Metodo
                    break;
                case 0:
                    // Metodo
                    break;


            }
        }

    }
}
