using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.IO;
using System.Windows.Forms;

namespace FrenteCaixa
{
    class Produto
    {
        protected int codBarras;
        protected float preco;
        public float custo { get; set; }
        public String nome { get; set; }

        Conexao conexao = new Conexao();
        Log log = new Log();

        public float getPreco()
        {
            return preco;
        }

        public void setCodBarras(int cod)
        {
            codBarras = cod;
        }

        public int getCodBarras()
        {
            return codBarras;
        }

        public void setPreco(float preco)
        {
            this.preco = preco;
        }
    }
}
