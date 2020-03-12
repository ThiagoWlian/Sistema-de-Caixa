using MySql.Data.MySqlClient;
using System;

namespace FrenteCaixa
{
    class ItensVenda : Produto
    {
        public int vendaID { get; set; }
        public int quantidadeItens { get; set; }
        public float precoTotal { get; set; }

        public ItensVenda(int vendaID, int codBarras, int quantidadeItens, float precoUnitario, float precoTotal)
        {
            this.vendaID = vendaID;
            this.codBarras = codBarras;
            this.quantidadeItens = quantidadeItens;
            this.preco = precoUnitario;
            this.precoTotal = precoTotal;
        }
    }

}
