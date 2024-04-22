
namespace SST
{
    partial class Cadastro_Produtos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro_Produtos));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TB_nome = new System.Windows.Forms.TextBox();
            this.TB_qtd = new System.Windows.Forms.TextBox();
            this.TB_val_compra = new System.Windows.Forms.TextBox();
            this.TB_val_venda = new System.Windows.Forms.TextBox();
            this.TB_val_lucro = new System.Windows.Forms.TextBox();
            this.TB_cod_sku = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Produto:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quantidade:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor de Compra:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Valor de Venda:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Valor de Lucro:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Código SKU:";
            // 
            // TB_nome
            // 
            this.TB_nome.Location = new System.Drawing.Point(78, 25);
            this.TB_nome.Name = "TB_nome";
            this.TB_nome.Size = new System.Drawing.Size(287, 20);
            this.TB_nome.TabIndex = 6;
            // 
            // TB_qtd
            // 
            this.TB_qtd.Location = new System.Drawing.Point(98, 57);
            this.TB_qtd.Name = "TB_qtd";
            this.TB_qtd.Size = new System.Drawing.Size(145, 20);
            this.TB_qtd.TabIndex = 7;
            // 
            // TB_val_compra
            // 
            this.TB_val_compra.Location = new System.Drawing.Point(127, 89);
            this.TB_val_compra.Name = "TB_val_compra";
            this.TB_val_compra.Size = new System.Drawing.Size(116, 20);
            this.TB_val_compra.TabIndex = 8;
            // 
            // TB_val_venda
            // 
            this.TB_val_venda.Location = new System.Drawing.Point(120, 121);
            this.TB_val_venda.Name = "TB_val_venda";
            this.TB_val_venda.Size = new System.Drawing.Size(123, 20);
            this.TB_val_venda.TabIndex = 9;
            this.TB_val_venda.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // TB_val_lucro
            // 
            this.TB_val_lucro.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TB_val_lucro.Enabled = false;
            this.TB_val_lucro.Location = new System.Drawing.Point(116, 153);
            this.TB_val_lucro.Name = "TB_val_lucro";
            this.TB_val_lucro.Size = new System.Drawing.Size(127, 20);
            this.TB_val_lucro.TabIndex = 10;
            // 
            // TB_cod_sku
            // 
            this.TB_cod_sku.Location = new System.Drawing.Point(101, 185);
            this.TB_cod_sku.Name = "TB_cod_sku";
            this.TB_cod_sku.Size = new System.Drawing.Size(142, 20);
            this.TB_cod_sku.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(237, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 84);
            this.button1.TabIndex = 12;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 209);
            this.panel1.TabIndex = 14;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Cadastro_Produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 233);
            this.Controls.Add(this.TB_cod_sku);
            this.Controls.Add(this.TB_val_lucro);
            this.Controls.Add(this.TB_val_venda);
            this.Controls.Add(this.TB_val_compra);
            this.Controls.Add(this.TB_qtd);
            this.Controls.Add(this.TB_nome);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Cadastro_Produtos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Produto";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TB_nome;
        private System.Windows.Forms.TextBox TB_qtd;
        private System.Windows.Forms.TextBox TB_val_compra;
        private System.Windows.Forms.TextBox TB_val_venda;
        private System.Windows.Forms.TextBox TB_val_lucro;
        private System.Windows.Forms.TextBox TB_cod_sku;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
    }
}