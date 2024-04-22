
namespace SST
{
    partial class W_Produtos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(W_Produtos));
            this.sSTDataSet = new SST.SSTDataSet();
            this.sSTDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRODUTOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sSTDataSet1 = new SST.SSTDataSet1();
            this.pRODUTOSTableAdapter = new SST.SSTDataSet1TableAdapters.PRODUTOSTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dtg_produtos = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.financeiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fecharToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Tb_Id = new System.Windows.Forms.TextBox();
            this.Tb_ValLuc_select = new System.Windows.Forms.TextBox();
            this.Tb_ValVend_select = new System.Windows.Forms.TextBox();
            this.Tb_ValCp_select = new System.Windows.Forms.TextBox();
            this.Tb_qtd_select = new System.Windows.Forms.TextBox();
            this.Tb_nome_select = new System.Windows.Forms.TextBox();
            this.Tb_cod_select = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.sSTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sSTDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUTOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sSTDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_produtos)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sSTDataSet
            // 
            this.sSTDataSet.DataSetName = "SSTDataSet";
            this.sSTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sSTDataSetBindingSource
            // 
            this.sSTDataSetBindingSource.DataSource = this.sSTDataSet;
            this.sSTDataSetBindingSource.Position = 0;
            // 
            // pRODUTOSBindingSource
            // 
            this.pRODUTOSBindingSource.DataMember = "PRODUTOS";
            this.pRODUTOSBindingSource.DataSource = this.sSTDataSet1;
            // 
            // sSTDataSet1
            // 
            this.sSTDataSet1.DataSetName = "SSTDataSet1";
            this.sSTDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pRODUTOSTableAdapter
            // 
            this.pRODUTOSTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(56, 90);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(656, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(781, 90);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(185, 20);
            this.textBox4.TabIndex = 6;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(12, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 54);
            this.button2.TabIndex = 7;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(104, 30);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 54);
            this.button3.TabIndex = 8;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Location = new System.Drawing.Point(196, 30);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(86, 54);
            this.button4.TabIndex = 9;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dtg_produtos
            // 
            this.dtg_produtos.AllowUserToAddRows = false;
            this.dtg_produtos.AllowUserToDeleteRows = false;
            this.dtg_produtos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_produtos.Location = new System.Drawing.Point(12, 116);
            this.dtg_produtos.Name = "dtg_produtos";
            this.dtg_produtos.ReadOnly = true;
            this.dtg_produtos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_produtos.Size = new System.Drawing.Size(954, 490);
            this.dtg_produtos.TabIndex = 10;
            this.dtg_produtos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_produtos_CellClick);
            this.dtg_produtos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_produtos_CellContentClick);
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
            this.menuStrip1.Size = new System.Drawing.Size(981, 24);
            this.menuStrip1.TabIndex = 12;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Produto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(718, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Código Sku";
            // 
            // Tb_Id
            // 
            this.Tb_Id.Location = new System.Drawing.Point(932, 27);
            this.Tb_Id.Name = "Tb_Id";
            this.Tb_Id.Size = new System.Drawing.Size(37, 20);
            this.Tb_Id.TabIndex = 15;
            this.Tb_Id.Visible = false;
            // 
            // Tb_ValLuc_select
            // 
            this.Tb_ValLuc_select.Location = new System.Drawing.Point(878, 27);
            this.Tb_ValLuc_select.Name = "Tb_ValLuc_select";
            this.Tb_ValLuc_select.Size = new System.Drawing.Size(48, 20);
            this.Tb_ValLuc_select.TabIndex = 16;
            this.Tb_ValLuc_select.Visible = false;
            // 
            // Tb_ValVend_select
            // 
            this.Tb_ValVend_select.Location = new System.Drawing.Point(824, 27);
            this.Tb_ValVend_select.Name = "Tb_ValVend_select";
            this.Tb_ValVend_select.Size = new System.Drawing.Size(48, 20);
            this.Tb_ValVend_select.TabIndex = 17;
            this.Tb_ValVend_select.Visible = false;
            // 
            // Tb_ValCp_select
            // 
            this.Tb_ValCp_select.Location = new System.Drawing.Point(770, 27);
            this.Tb_ValCp_select.Name = "Tb_ValCp_select";
            this.Tb_ValCp_select.Size = new System.Drawing.Size(48, 20);
            this.Tb_ValCp_select.TabIndex = 18;
            this.Tb_ValCp_select.Visible = false;
            // 
            // Tb_qtd_select
            // 
            this.Tb_qtd_select.Location = new System.Drawing.Point(716, 27);
            this.Tb_qtd_select.Name = "Tb_qtd_select";
            this.Tb_qtd_select.Size = new System.Drawing.Size(48, 20);
            this.Tb_qtd_select.TabIndex = 19;
            this.Tb_qtd_select.Visible = false;
            // 
            // Tb_nome_select
            // 
            this.Tb_nome_select.Location = new System.Drawing.Point(662, 27);
            this.Tb_nome_select.Name = "Tb_nome_select";
            this.Tb_nome_select.Size = new System.Drawing.Size(48, 20);
            this.Tb_nome_select.TabIndex = 20;
            this.Tb_nome_select.Visible = false;
            // 
            // Tb_cod_select
            // 
            this.Tb_cod_select.Location = new System.Drawing.Point(611, 27);
            this.Tb_cod_select.Name = "Tb_cod_select";
            this.Tb_cod_select.Size = new System.Drawing.Size(45, 20);
            this.Tb_cod_select.TabIndex = 21;
            this.Tb_cod_select.Visible = false;
            // 
            // W_Produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 625);
            this.Controls.Add(this.Tb_cod_select);
            this.Controls.Add(this.Tb_nome_select);
            this.Controls.Add(this.Tb_qtd_select);
            this.Controls.Add(this.Tb_ValCp_select);
            this.Controls.Add(this.Tb_ValVend_select);
            this.Controls.Add(this.Tb_ValLuc_select);
            this.Controls.Add(this.Tb_Id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtg_produtos);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "W_Produtos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produtos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Enter += new System.EventHandler(this.W_Produtos_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.sSTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sSTDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUTOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sSTDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_produtos)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource sSTDataSetBindingSource;
        private SSTDataSet sSTDataSet;
        private SSTDataSet1 sSTDataSet1;
        private System.Windows.Forms.BindingSource pRODUTOSBindingSource;
        private SSTDataSet1TableAdapters.PRODUTOSTableAdapter pRODUTOSTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dtg_produtos;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem financeiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fecharToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Tb_Id;
        private System.Windows.Forms.TextBox Tb_ValLuc_select;
        private System.Windows.Forms.TextBox Tb_ValVend_select;
        private System.Windows.Forms.TextBox Tb_ValCp_select;
        private System.Windows.Forms.TextBox Tb_qtd_select;
        private System.Windows.Forms.TextBox Tb_nome_select;
        private System.Windows.Forms.TextBox Tb_cod_select;
    }
}

