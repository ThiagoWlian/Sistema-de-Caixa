using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace FrenteCaixa
{
    class Conexao
    {
        public MySqlConnection mysqlconexao = new MySqlConnection("Server=localhost;Database=caixa;Uid=root;Pwd=123456");
    }
}
