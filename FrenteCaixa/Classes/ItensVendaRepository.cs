using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace FrenteCaixa
{
    class ItensVendaRepository
    {
        Conexao conexao = new Conexao();
        Log log = new Log();
        public async void cadastraItensVenda(ItensVenda itensVenda)
        {
            try
            {
                String Mysql = "Insert into itens_venda (venda_cod,produto_cod,quantidade_itens,preco_unitario,preco_total) values (@vendacod,@produtocod,@quantidade,@precounitario,@precototal)";
                MySqlCommand comando = new MySqlCommand(Mysql, conexao.mysqlconexao);

                comando.Parameters.AddWithValue("@vendacod", itensVenda.vendaID);
                comando.Parameters.AddWithValue("@produtocod", itensVenda.getCodBarras());
                comando.Parameters.AddWithValue("@quantidade", itensVenda.quantidadeItens);
                comando.Parameters.AddWithValue("@precounitario", itensVenda.getPreco());
                comando.Parameters.AddWithValue("@precototal", itensVenda.precoTotal);

                await conexao.mysqlconexao.OpenAsync();
                await comando.ExecuteNonQueryAsync();
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
