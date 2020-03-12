using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FrenteCaixa.Classes
{
    class VendaRepository
    {
        Conexao conexao = new Conexao();
        Log log = new Log();
        public void obtemVendaID(Venda venda)
        {
            try
            {
                String Mysql = "Select MAX(cod)cod From venda";
                MySqlCommand command = new MySqlCommand(Mysql, conexao.mysqlconexao);
                conexao.mysqlconexao.Open();

                MySqlDataReader leitor = command.ExecuteReader();

                leitor.Read();

                venda.vendaID = int.Parse(leitor["Cod"].ToString());

                leitor.Close();
            }
            catch (Exception ex)
            {
                log.insereTextoArquivo(ex.ToString());
            }
            finally
            {
                conexao.mysqlconexao.Close();
            }
        }
        public void cadastraVenda(Venda venda)
        {
            try
            {
                String Mysql = "insert into Venda (Cliente_cod,Funcionario_cod,total,pagamento) values (@Cliente_cod,@Funcionario_cod,@total,@pagamento)";
                MySqlCommand command = new MySqlCommand(Mysql, conexao.mysqlconexao);

                command.Parameters.AddWithValue("@Cliente_cod", venda.clienteCod);
                command.Parameters.AddWithValue("@Funcionario_cod", venda.funcionarioCod);
                command.Parameters.AddWithValue("@total", venda.totalVenda);
                command.Parameters.AddWithValue("@pagamento", venda.valorPago);

                conexao.mysqlconexao.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                log.insereTextoArquivo(ex.ToString());
            }
            finally
            {
                conexao.mysqlconexao.Close();
            }
        }
    }
}
