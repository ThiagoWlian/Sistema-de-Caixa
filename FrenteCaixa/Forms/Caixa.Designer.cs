namespace FrenteCaixa
{
    partial class Caixa
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnInserirItem = new System.Windows.Forms.Button();
            this.txtbNome = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbCodBarras = new System.Windows.Forms.TextBox();
            this.txtbPrecoTotalItem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbQuantidadeProduto = new System.Windows.Forms.TextBox();
            this.txtbPrecoUnitario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dataGridListaItens = new System.Windows.Forms.DataGridView();
            this.Numeracao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codBarra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lbTotalVenda = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListaItens)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 326);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(252, 257);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(997, 27);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.btnInserirItem);
            this.panel3.Controls.Add(this.txtbNome);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtbCodBarras);
            this.panel3.Controls.Add(this.txtbPrecoTotalItem);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtbQuantidadeProduto);
            this.panel3.Controls.Add(this.txtbPrecoUnitario);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(264, 33);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(239, 420);
            this.panel3.TabIndex = 2;
            // 
            // btnInserirItem
            // 
            this.btnInserirItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserirItem.Location = new System.Drawing.Point(44, 340);
            this.btnInserirItem.Name = "btnInserirItem";
            this.btnInserirItem.Size = new System.Drawing.Size(146, 47);
            this.btnInserirItem.TabIndex = 0;
            this.btnInserirItem.Text = "INSERIR";
            this.btnInserirItem.UseVisualStyleBackColor = true;
            this.btnInserirItem.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtbNome
            // 
            this.txtbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbNome.Location = new System.Drawing.Point(12, 88);
            this.txtbNome.Name = "txtbNome";
            this.txtbNome.ReadOnly = true;
            this.txtbNome.Size = new System.Drawing.Size(209, 35);
            this.txtbNome.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Nome";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Preço Total";
            // 
            // txtbCodBarras
            // 
            this.txtbCodBarras.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbCodBarras.Location = new System.Drawing.Point(12, 27);
            this.txtbCodBarras.Name = "txtbCodBarras";
            this.txtbCodBarras.Size = new System.Drawing.Size(209, 35);
            this.txtbCodBarras.TabIndex = 3;
            this.txtbCodBarras.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // txtbPrecoTotalItem
            // 
            this.txtbPrecoTotalItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbPrecoTotalItem.Location = new System.Drawing.Point(12, 282);
            this.txtbPrecoTotalItem.Name = "txtbPrecoTotalItem";
            this.txtbPrecoTotalItem.ReadOnly = true;
            this.txtbPrecoTotalItem.Size = new System.Drawing.Size(209, 35);
            this.txtbPrecoTotalItem.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Código de Barras";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Preço Unitário";
            // 
            // txtbQuantidadeProduto
            // 
            this.txtbQuantidadeProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbQuantidadeProduto.Location = new System.Drawing.Point(12, 149);
            this.txtbQuantidadeProduto.Name = "txtbQuantidadeProduto";
            this.txtbQuantidadeProduto.Size = new System.Drawing.Size(209, 35);
            this.txtbQuantidadeProduto.TabIndex = 5;
            this.txtbQuantidadeProduto.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtbPrecoUnitario
            // 
            this.txtbPrecoUnitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbPrecoUnitario.Location = new System.Drawing.Point(12, 215);
            this.txtbPrecoUnitario.Name = "txtbPrecoUnitario";
            this.txtbPrecoUnitario.ReadOnly = true;
            this.txtbPrecoUnitario.Size = new System.Drawing.Size(209, 35);
            this.txtbPrecoUnitario.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Quantidade";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(509, 33);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(485, 72);
            this.panel4.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(213, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 31);
            this.label5.TabIndex = 0;
            this.label5.Text = "ITENS";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.dataGridListaItens);
            this.panel5.Location = new System.Drawing.Point(506, 109);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(491, 344);
            this.panel5.TabIndex = 4;
            // 
            // dataGridListaItens
            // 
            this.dataGridListaItens.AllowUserToAddRows = false;
            this.dataGridListaItens.AllowUserToDeleteRows = false;
            this.dataGridListaItens.AllowUserToResizeColumns = false;
            this.dataGridListaItens.AllowUserToResizeRows = false;
            this.dataGridListaItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridListaItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numeracao,
            this.codBarra,
            this.nome,
            this.quantidade,
            this.precoUnitario,
            this.precoTotal});
            this.dataGridListaItens.Location = new System.Drawing.Point(3, 2);
            this.dataGridListaItens.Name = "dataGridListaItens";
            this.dataGridListaItens.Size = new System.Drawing.Size(485, 342);
            this.dataGridListaItens.TabIndex = 0;
            // 
            // Numeracao
            // 
            this.Numeracao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Numeracao.Frozen = true;
            this.Numeracao.HeaderText = "N°";
            this.Numeracao.Name = "Numeracao";
            this.Numeracao.ReadOnly = true;
            this.Numeracao.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Numeracao.Width = 30;
            // 
            // codBarra
            // 
            this.codBarra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.codBarra.Frozen = true;
            this.codBarra.HeaderText = "Código de Barras";
            this.codBarra.Name = "codBarra";
            this.codBarra.ReadOnly = true;
            this.codBarra.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.codBarra.Width = 145;
            // 
            // nome
            // 
            this.nome.Frozen = true;
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            // 
            // quantidade
            // 
            this.quantidade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.quantidade.Frozen = true;
            this.quantidade.HeaderText = "Q°";
            this.quantidade.Name = "quantidade";
            this.quantidade.ReadOnly = true;
            this.quantidade.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.quantidade.Width = 30;
            // 
            // precoUnitario
            // 
            this.precoUnitario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.precoUnitario.Frozen = true;
            this.precoUnitario.HeaderText = "Preço Unitário";
            this.precoUnitario.Name = "precoUnitario";
            this.precoUnitario.ReadOnly = true;
            this.precoUnitario.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.precoUnitario.Width = 75;
            // 
            // precoTotal
            // 
            this.precoTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.precoTotal.Frozen = true;
            this.precoTotal.HeaderText = "Preço Total";
            this.precoTotal.Name = "precoTotal";
            this.precoTotal.ReadOnly = true;
            this.precoTotal.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.precoTotal.Width = 75;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel6.Controls.Add(this.label7);
            this.panel6.Location = new System.Drawing.Point(0, 364);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(258, 89);
            this.panel6.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(7, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(246, 42);
            this.label7.TabIndex = 1;
            this.label7.Text = "CAIXA LIVRE";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Location = new System.Drawing.Point(0, 459);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(503, 50);
            this.panel7.TabIndex = 6;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel8.Controls.Add(this.lbTotalVenda);
            this.panel8.Controls.Add(this.label6);
            this.panel8.Location = new System.Drawing.Point(506, 459);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(491, 50);
            this.panel8.TabIndex = 7;
            this.panel8.Paint += new System.Windows.Forms.PaintEventHandler(this.panel8_Paint);
            // 
            // lbTotalVenda
            // 
            this.lbTotalVenda.AutoSize = true;
            this.lbTotalVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalVenda.ForeColor = System.Drawing.Color.White;
            this.lbTotalVenda.Location = new System.Drawing.Point(272, 8);
            this.lbTotalVenda.Name = "lbTotalVenda";
            this.lbTotalVenda.Size = new System.Drawing.Size(0, 37);
            this.lbTotalVenda.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(3, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 37);
            this.label6.TabIndex = 1;
            this.label6.Text = "TOTAL:";
            // 
            // Caixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(997, 509);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Name = "Caixa";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Caixa_KeyDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListaItens)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbCodBarras;
        private System.Windows.Forms.TextBox txtbPrecoTotalItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbQuantidadeProduto;
        private System.Windows.Forms.TextBox txtbPrecoUnitario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridListaItens;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtbNome;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnInserirItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numeracao;
        private System.Windows.Forms.DataGridViewTextBoxColumn codBarra;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoTotal;
        private System.Windows.Forms.Label lbTotalVenda;
    }
}

