
namespace SST.View
{
    partial class W_Edicao_Venda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(W_Edicao_Venda));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.financeiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fecharToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dtg_lista_prod_venda = new System.Windows.Forms.DataGridView();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Dtg_Produtos = new System.Windows.Forms.DataGridView();
            this.Tb_valor_produtos = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Cb_Situacao = new System.Windows.Forms.ComboBox();
            this.Tb_cliente = new System.Windows.Forms.TextBox();
            this.Tb_valor_compra = new System.Windows.Forms.TextBox();
            this.Tb_qtd_itens = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Tb_ValVenda_produto_selec = new System.Windows.Forms.TextBox();
            this.tb_custo_produto_selec = new System.Windows.Forms.TextBox();
            this.Tb_idprodt_selec = new System.Windows.Forms.TextBox();
            this.Tb_produto_selec = new System.Windows.Forms.TextBox();
            this.Tb_id_venda = new System.Windows.Forms.TextBox();
            this.Cb_forma_pag = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DT_data_venda = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_lista_prod_venda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dtg_Produtos)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtosToolStripMenuItem,
            this.vendasToolStripMenuItem,
            this.financeiroToolStripMenuItem,
            this.fecharToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(990, 24);
            this.menuStrip1.TabIndex = 51;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.produtosToolStripMenuItem.Text = "Produtos";
            this.produtosToolStripMenuItem.Click += new System.EventHandler(this.produtosToolStripMenuItem_Click);
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.vendasToolStripMenuItem.Text = "Vendas";
            this.vendasToolStripMenuItem.Click += new System.EventHandler(this.vendasToolStripMenuItem_Click);
            // 
            // financeiroToolStripMenuItem
            // 
            this.financeiroToolStripMenuItem.Name = "financeiroToolStripMenuItem";
            this.financeiroToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.financeiroToolStripMenuItem.Text = "Empresarial";
            this.financeiroToolStripMenuItem.Click += new System.EventHandler(this.financeiroToolStripMenuItem_Click);
            // 
            // fecharToolStripMenuItem
            // 
            this.fecharToolStripMenuItem.Name = "fecharToolStripMenuItem";
            this.fecharToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fecharToolStripMenuItem.Text = "Fechar";
            this.fecharToolStripMenuItem.Click += new System.EventHandler(this.fecharToolStripMenuItem_Click);
            // 
            // dtg_lista_prod_venda
            // 
            this.dtg_lista_prod_venda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_lista_prod_venda.Location = new System.Drawing.Point(543, 179);
            this.dtg_lista_prod_venda.Name = "dtg_lista_prod_venda";
            this.dtg_lista_prod_venda.Size = new System.Drawing.Size(431, 365);
            this.dtg_lista_prod_venda.TabIndex = 49;
            this.dtg_lista_prod_venda.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_lista_prod_venda_CellClick);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(14, 149);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(403, 20);
            this.textBox3.TabIndex = 45;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(682, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 20);
            this.label3.TabIndex = 44;
            this.label3.Text = "Produtos da Venda";
            // 
            // Dtg_Produtos
            // 
            this.Dtg_Produtos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dtg_Produtos.Location = new System.Drawing.Point(14, 189);
            this.Dtg_Produtos.Name = "Dtg_Produtos";
            this.Dtg_Produtos.Size = new System.Drawing.Size(431, 440);
            this.Dtg_Produtos.TabIndex = 43;
            this.Dtg_Produtos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dtg_Produtos_CellClick_1);
            this.Dtg_Produtos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dtg_Produtos_CellContentClick);
            // 
            // Tb_valor_produtos
            // 
            this.Tb_valor_produtos.Location = new System.Drawing.Point(574, 101);
            this.Tb_valor_produtos.Name = "Tb_valor_produtos";
            this.Tb_valor_produtos.Size = new System.Drawing.Size(106, 20);
            this.Tb_valor_produtos.TabIndex = 42;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(448, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 17);
            this.label10.TabIndex = 41;
            this.label10.Text = "Valor em Produtos:";
            // 
            // Cb_Situacao
            // 
            this.Cb_Situacao.FormattingEnabled = true;
            this.Cb_Situacao.Items.AddRange(new object[] {
            "1- Pago",
            "2- Pago a Prazo",
            "3- Não Pago"});
            this.Cb_Situacao.Location = new System.Drawing.Point(512, 71);
            this.Cb_Situacao.Name = "Cb_Situacao";
            this.Cb_Situacao.Size = new System.Drawing.Size(168, 21);
            this.Cb_Situacao.TabIndex = 40;
            // 
            // Tb_cliente
            // 
            this.Tb_cliente.Location = new System.Drawing.Point(66, 71);
            this.Tb_cliente.Name = "Tb_cliente";
            this.Tb_cliente.Size = new System.Drawing.Size(376, 20);
            this.Tb_cliente.TabIndex = 38;
            // 
            // Tb_valor_compra
            // 
            this.Tb_valor_compra.Location = new System.Drawing.Point(129, 101);
            this.Tb_valor_compra.Name = "Tb_valor_compra";
            this.Tb_valor_compra.Size = new System.Drawing.Size(101, 20);
            this.Tb_valor_compra.TabIndex = 37;
            // 
            // Tb_qtd_itens
            // 
            this.Tb_qtd_itens.Location = new System.Drawing.Point(373, 101);
            this.Tb_qtd_itens.Name = "Tb_qtd_itens";
            this.Tb_qtd_itens.Size = new System.Drawing.Size(69, 20);
            this.Tb_qtd_itens.TabIndex = 36;
            this.Tb_qtd_itens.TextChanged += new System.EventHandler(this.Tb_qtd_itens_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 17);
            this.label8.TabIndex = 35;
            this.label8.Text = "Cliente:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(236, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 17);
            this.label6.TabIndex = 34;
            this.label6.Text = "Quantidade de Itens:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(448, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 33;
            this.label4.Text = "Situação:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 17);
            this.label2.TabIndex = 32;
            this.label2.Text = "Valor da Compra:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(367, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 25);
            this.label1.TabIndex = 31;
            this.label1.Text = "Edição de Vendas";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.Location = new System.Drawing.Point(837, 550);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(137, 77);
            this.button4.TabIndex = 50;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(452, 399);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 85);
            this.button3.TabIndex = 48;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(452, 303);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 85);
            this.button2.TabIndex = 47;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::SST.Properties.Resources._159657;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(419, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 23);
            this.button1.TabIndex = 46;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Tb_ValVenda_produto_selec
            // 
            this.Tb_ValVenda_produto_selec.Location = new System.Drawing.Point(525, 602);
            this.Tb_ValVenda_produto_selec.Name = "Tb_ValVenda_produto_selec";
            this.Tb_ValVenda_produto_selec.Size = new System.Drawing.Size(63, 20);
            this.Tb_ValVenda_produto_selec.TabIndex = 55;
            // 
            // tb_custo_produto_selec
            // 
            this.tb_custo_produto_selec.Location = new System.Drawing.Point(525, 579);
            this.tb_custo_produto_selec.Name = "tb_custo_produto_selec";
            this.tb_custo_produto_selec.Size = new System.Drawing.Size(63, 20);
            this.tb_custo_produto_selec.TabIndex = 54;
            // 
            // Tb_idprodt_selec
            // 
            this.Tb_idprodt_selec.Location = new System.Drawing.Point(456, 602);
            this.Tb_idprodt_selec.Name = "Tb_idprodt_selec";
            this.Tb_idprodt_selec.Size = new System.Drawing.Size(63, 20);
            this.Tb_idprodt_selec.TabIndex = 53;
            // 
            // Tb_produto_selec
            // 
            this.Tb_produto_selec.Location = new System.Drawing.Point(456, 579);
            this.Tb_produto_selec.Name = "Tb_produto_selec";
            this.Tb_produto_selec.Size = new System.Drawing.Size(63, 20);
            this.Tb_produto_selec.TabIndex = 52;
            // 
            // Tb_id_venda
            // 
            this.Tb_id_venda.Location = new System.Drawing.Point(652, 38);
            this.Tb_id_venda.Name = "Tb_id_venda";
            this.Tb_id_venda.Size = new System.Drawing.Size(28, 20);
            this.Tb_id_venda.TabIndex = 56;
            // 
            // Cb_forma_pag
            // 
            this.Cb_forma_pag.FormattingEnabled = true;
            this.Cb_forma_pag.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.Cb_forma_pag.Location = new System.Drawing.Point(832, 70);
            this.Cb_forma_pag.Name = "Cb_forma_pag";
            this.Cb_forma_pag.Size = new System.Drawing.Size(142, 21);
            this.Cb_forma_pag.TabIndex = 60;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(686, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 17);
            this.label7.TabIndex = 59;
            this.label7.Text = "Forma de Pagamento:";
            // 
            // DT_data_venda
            // 
            this.DT_data_venda.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DT_data_venda.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DT_data_venda.Location = new System.Drawing.Point(723, 100);
            this.DT_data_venda.Name = "DT_data_venda";
            this.DT_data_venda.Size = new System.Drawing.Size(95, 20);
            this.DT_data_venda.TabIndex = 58;
            this.DT_data_venda.Value = new System.DateTime(2021, 6, 1, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(683, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 57;
            this.label5.Text = "Data:";
            // 
            // W_Edicao_Venda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 641);
            this.Controls.Add(this.Cb_forma_pag);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DT_data_venda);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Tb_id_venda);
            this.Controls.Add(this.Tb_ValVenda_produto_selec);
            this.Controls.Add(this.tb_custo_produto_selec);
            this.Controls.Add(this.Tb_idprodt_selec);
            this.Controls.Add(this.Tb_produto_selec);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dtg_lista_prod_venda);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Dtg_Produtos);
            this.Controls.Add(this.Tb_valor_produtos);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Cb_Situacao);
            this.Controls.Add(this.Tb_cliente);
            this.Controls.Add(this.Tb_valor_compra);
            this.Controls.Add(this.Tb_qtd_itens);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "W_Edicao_Venda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edição de Venda";
            this.Load += new System.EventHandler(this.W_Edicao_Venda_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_lista_prod_venda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dtg_Produtos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem financeiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fecharToolStripMenuItem;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dtg_lista_prod_venda;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView Dtg_Produtos;
        private System.Windows.Forms.TextBox Tb_valor_produtos;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox Cb_Situacao;
        private System.Windows.Forms.TextBox Tb_cliente;
        private System.Windows.Forms.TextBox Tb_valor_compra;
        private System.Windows.Forms.TextBox Tb_qtd_itens;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Tb_ValVenda_produto_selec;
        private System.Windows.Forms.TextBox tb_custo_produto_selec;
        private System.Windows.Forms.TextBox Tb_idprodt_selec;
        private System.Windows.Forms.TextBox Tb_produto_selec;
        private System.Windows.Forms.TextBox Tb_id_venda;
        private System.Windows.Forms.ComboBox Cb_forma_pag;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker DT_data_venda;
        private System.Windows.Forms.Label label5;
    }
}