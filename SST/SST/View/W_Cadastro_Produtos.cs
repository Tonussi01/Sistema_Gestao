using SST.Models;
using SST.Entities;
using System;
using System.Windows.Forms;

namespace SST
{
    public partial class Cadastro_Produtos : Form
    {
        Produtos obj = new Produtos();
        public Cadastro_Produtos()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if((TB_cod_sku.Text != "") && (TB_qtd.Text != "") && (TB_val_compra.Text != "") && 
               (TB_val_venda.Text != "") && (TB_nome.Text != ""))
            {
                salvar();
                TB_cod_sku.Text = "";
                TB_qtd.Text = "";
                TB_val_compra.Text = "";
                TB_val_lucro.Text = "";
                TB_val_venda.Text = "";
                TB_nome.Text = "";
            }
            else
            {
                MessageBox.Show("É necessario preencher todos os campos sobre o produto para cadastra-lo");
            }
        }

        private void salvar()
        {
            float Lucro, Val_Venda, Val_Compra;
            Val_Venda = Convert.ToSingle(TB_val_venda.Text);
            Val_Compra = Convert.ToSingle(TB_val_compra.Text);
            Lucro = Val_Venda - Val_Compra;
            TB_val_lucro.Text = Lucro.ToString();
            try
            {
                obj.Nome = TB_nome.Text;
                obj.Quantidade = Convert.ToInt32(TB_qtd.Text);
                obj.Valor_compra = Convert.ToSingle(TB_val_compra.Text);
                obj.Valor_venda = Convert.ToSingle(TB_val_venda.Text);
                obj.Valor_lucro = Convert.ToSingle(TB_val_lucro.Text);
                obj.Codigo_sku = TB_cod_sku.Text;

                Produto_Model.Inserir(obj);
                MessageBox.Show("Inserido com Sucesso");                
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: "+ erro);
            }      
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
