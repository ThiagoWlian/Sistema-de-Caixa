using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace FrenteCaixa.Classes
{
    class ProdutoRepository
    {
        Conexao conexao = new Conexao();
        Log log = new Log();
        public async void obtemDadosProdutoBD(Produto produto)
        {
            try
            {
                String Mysql = "Select nome,preco_venda,preco_custo From produto Where cod_barras = " + produto.getCodBarras() + "";
                MySqlCommand command = new MySqlCommand(Mysql, conexao.mysqlconexao);
                await conexao.mysqlconexao.OpenAsync();

                MySqlDataReader leitor = command.ExecuteReader();

                while (await leitor.ReadAsync())
                {
                    produto.nome = leitor["nome"].ToString();
                    produto.setPreco(float.Parse(leitor["preco_venda"].ToString()));
                    produto.custo = float.Parse(leitor["preco_custo"].ToString());
                }

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
    }
}
