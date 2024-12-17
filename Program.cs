using MySql.Data.MySqlClient;
using Projeto_ATLAS.Infraestrutura.Servico;

namespace Projeto_ATLAS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try{
                var Conexao = new MySqlAdaptadorConexao().ObterConexao();
                Conexao.Open();
                Console.WriteLine(Conexao.State);
                Conexao.Close();
                Console.WriteLine(Conexao.State);

            }catch (MySqlException e) {
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
