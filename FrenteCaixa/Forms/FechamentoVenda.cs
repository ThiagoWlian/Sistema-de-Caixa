using FrenteCaixa.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrenteCaixa
{
    public partial class FechamentoVenda : Form
    {
        public FechamentoVenda()
        {
            InitializeComponent();
        }

        private DataTable tabelaItensVenda = new DataTable();

        public void setValorTotal(float valorTotal)
        {
            txtbValorCompra.Text = valorTotal.ToString("C");
        }
        public void criaColunasTabelaItensVenda()
        {
            tabelaItensVenda.Columns.Add("codBarras", typeof(int));
            tabelaItensVenda.Columns.Add("quantidadeItens", typeof(int));
            tabelaItensVenda.Columns.Add("precoUnitario", typeof(float));
            tabelaItensVenda.Columns.Add("precoTotal", typeof(float));
        }
        public void setDataTableItensVenda(int codBarras, int quantidade, float precoUnitario, float precoTotal)
        {
            tabelaItensVenda.Rows.Add(codBarras, quantidade, precoUnitario, precoTotal);
        }

        private void FechamentoVenda_Load(object sender, EventArgs e)
        {

        }

        private void btnfinalizar_Click(object sender, EventArgs e)
        {
            Venda venda = new Venda(int.Parse(txtbFuncionarioCod.Text),int.Parse(txtbClienteCod.Text),float.Parse(txtbValorCompra.Text.Replace("R$", "")),float.Parse(txtbValorPagamento.Text));
            VendaRepository vendaRepository = new VendaRepository();
            vendaRepository.cadastraVenda(venda);
            vendaRepository.obtemVendaID(venda);
            for (int i = 0; i < tabelaItensVenda.Rows.Count; i++)
            {
                ItensVenda itensVenda = new ItensVenda(venda.vendaID, int.Parse(tabelaItensVenda.Rows[i]["codBarras"].ToString()), int.Parse(tabelaItensVenda.Rows[i]["quantidadeItens"].ToString()), float.Parse(tabelaItensVenda.Rows[i]["precoUnitario"].ToString()), float.Parse(tabelaItensVenda.Rows[i]["precoTotal"].ToString()));
                ItensVendaRepository itensvendaRepository = new ItensVendaRepository();
                itensvendaRepository.cadastraItensVenda(itensVenda);
            }
        }
    }
}
