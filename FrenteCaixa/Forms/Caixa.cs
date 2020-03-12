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
    public partial class Caixa : Form
    {
        public Caixa()
        {
            InitializeComponent();
        }

        Venda venda = new Venda();
        Produto produto = new Produto();
        ProdutoRepository produtoRepository = new ProdutoRepository();

        public void limparCampos()
        {
            txtbCodBarras.Text = "";
            txtbNome.Text = "";
            txtbPrecoTotalItem.Text = "";
            txtbPrecoUnitario.Text = "";
            txtbQuantidadeProduto.Text = "";
        }
        public void carregaInformacoesProdutoTextbox()
        {
            txtbNome.Text = produto.nome;
            txtbQuantidadeProduto.Text = "1";
            txtbPrecoUnitario.Text = produto.getPreco().ToString("C");
            txtbPrecoTotalItem.Text = txtbPrecoUnitario.Text;
        }
        public void carregaInformacoesProdutoDatagrid()
        {
            dataGridListaItens.Rows.Add();
            dataGridListaItens.Rows[dataGridListaItens.Rows.Count-1].Cells[0].Value = dataGridListaItens.Rows.Count;
            dataGridListaItens.Rows[dataGridListaItens.Rows.Count - 1].Cells[1].Value = txtbCodBarras.Text;
            dataGridListaItens.Rows[dataGridListaItens.Rows.Count - 1].Cells[2].Value = txtbNome.Text;
            dataGridListaItens.Rows[dataGridListaItens.Rows.Count - 1].Cells[3].Value = txtbQuantidadeProduto.Text;
            dataGridListaItens.Rows[dataGridListaItens.Rows.Count - 1].Cells[4].Value = txtbPrecoUnitario.Text;
            dataGridListaItens.Rows[dataGridListaItens.Rows.Count - 1].Cells[5].Value = txtbPrecoTotalItem.Text;
        }

        public void ajustaValorTxtbQuantidade()
        {
            if (int.TryParse(txtbQuantidadeProduto.Text, out int resultado) != true)
            {
                txtbQuantidadeProduto.Text = "1";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            carregaInformacoesProdutoDatagrid();
            venda.calculaTotalVenda(float.Parse(txtbPrecoTotalItem.Text.Replace("R$", "")));
            lbTotalVenda.Text = venda.totalVenda.ToString("C");
            limparCampos();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (txtbQuantidadeProduto.Text == "0")
            {
                txtbQuantidadeProduto.Text = "1";
            }
            if (txtbQuantidadeProduto.Text != String.Empty && txtbPrecoUnitario.Text != String.Empty && txtbPrecoTotalItem.Text != String.Empty && int.TryParse(txtbQuantidadeProduto.Text, out int resultado))
            {
                txtbPrecoTotalItem.Text = (float.Parse(txtbQuantidadeProduto.Text) * (float.Parse(txtbPrecoUnitario.Text.Replace("R$", "")))).ToString("C");
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ajustaValorTxtbQuantidade();
                produto.setCodBarras(int.Parse(txtbCodBarras.Text));
                produtoRepository.obtemDadosProdutoBD(produto);
                carregaInformacoesProdutoTextbox();
            }
        }

        private void Caixa_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.End)
            {
                FechamentoVenda fechamento = new FechamentoVenda();
                fechamento.criaColunasTabelaItensVenda();
                for (int N = 0; N < dataGridListaItens.Rows.Count; N++)
                {
                    fechamento.setDataTableItensVenda(int.Parse(dataGridListaItens.Rows[N].Cells[1].Value.ToString()), int.Parse(dataGridListaItens.Rows[N].Cells[3].Value.ToString()), float.Parse(dataGridListaItens.Rows[N].Cells[4].Value.ToString().Replace("R$", "")), float.Parse(dataGridListaItens.Rows[N].Cells[5].Value.ToString().Replace("R$", "")));
                    fechamento.setValorTotal(venda.totalVenda);
                }
                this.Hide();
                fechamento.ShowDialog();
                this.Show();
            }
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
