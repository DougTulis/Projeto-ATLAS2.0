using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ATLAS.Infraestrutura.Servico
{
    internal class MySqlAdaptadorConexao
    {
        string conexaoSql = "Server=localhost;Port=3306;Database=atlas;Uid=root;Pwd=nova_senha;";

        public MySqlConnection ObterConexao()
        {
            return new MySqlConnection(conexaoSql);
        }
    }


}
