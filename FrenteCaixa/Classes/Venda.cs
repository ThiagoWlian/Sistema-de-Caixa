using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace FrenteCaixa
{
    class Venda
    {
        Conexao conexao = new Conexao();
        Log log = new Log();
        Produto produto = new Produto();

        public int vendaID { get; set; }
        public int funcionarioCod { get; set; }
        public int clienteCod { get; set; }
        public float totalVenda { get; set; }
        public float valorPago{ get; set; }
        public float troco { get; set; }

        public Venda(int funcionarioCod, int clienteCod, float totalVenda, float valorPago)
        {
            this.funcionarioCod = funcionarioCod;
            this.clienteCod = clienteCod;
            this.totalVenda = totalVenda;
            this.valorPago = valorPago;
        }
        public Venda(){}

        public void calculaTotalVenda(float valor)
        {
            totalVenda += valor;
        }
    }
}
