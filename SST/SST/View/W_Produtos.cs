using SST.Models;
using SST.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SST.View;

namespace SST
{
    public partial class W_Produtos : Form
    {
        Produtos obj = new Produtos();

        public W_Produtos()
        {
            InitializeComponent();
            Listar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cadastro_Produtos form = new Cadastro_Produtos();
            form.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void Listar()
        {
            try
            {
                List<Produtos> lista = new List<Produtos>();
                lista = new Produto_Model().Listar();

                dtg_produtos.DataSource = lista;
                dtg_produtos.Columns[0].Visible = false;
                dtg_produtos.Columns[1].HeaderText = "Nome";
                dtg_produtos.Columns[1].Width = 310;
                dtg_produtos.Columns[2].HeaderText = "Quantidade";
                dtg_produtos.Columns[3].HeaderText = "Valor de Compra";
                dtg_produtos.Columns[4].HeaderText = "Valor de Venda";
                dtg_produtos.Columns[5].HeaderText = "Valor de Lucro";
                dtg_produtos.Columns[6].HeaderText = "Disponivel";
                dtg_produtos.Columns[7].HeaderText = "Codigo SKU";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível listar os dados" + ex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Listar();

        }

        private void financeiroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<W_Empresarial>().Count() > 0)
            {
                Application.OpenForms.OfType<W_Empresarial>().First().Focus();
            }
            else
            {
                W_Empresarial form = new W_Empresarial();
                form.Show();
            }
        }

        private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<W_Vendas>().Count() > 0)
            {
                Application.OpenForms.OfType<W_Vendas>().First().Focus();
            }
            else
            {
                W_Vendas form = new W_Vendas();
                form.Show();
            }
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<W_Produtos>().Count() > 0)
            {
                Application.OpenForms.OfType<W_Produtos>().First().Focus();
            }
            else
            {
                W_Produtos form = new W_Produtos();
                form.Show();
            }
        }

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            obj.Id = Convert.ToInt32(Tb_Id.Text);
            obj.Nome = dtg_produtos.CurrentRow.Cells[1].Value.ToString();
            obj.Quantidade = Convert.ToInt32(dtg_produtos.CurrentRow.Cells[2].Value);
            obj.Valor_compra = Convert.ToSingle(dtg_produtos.CurrentRow.Cells[3].Value);
            obj.Valor_venda = Convert.ToSingle(dtg_produtos.CurrentRow.Cells[4].Value);
            obj.Valor_lucro = Convert.ToSingle(dtg_produtos.CurrentRow.Cells[5].Value);
            obj.Codigo_sku = dtg_produtos.CurrentRow.Cells[7].Value.ToString();

            W_Edicao_Produto form = new W_Edicao_Produto(obj);
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DeletaProduto();
        }

        private void DeletaProduto()
        {
            try
            {
                obj.Id = Convert.ToInt32(Tb_Id.Text);
                Produto_Model.Deletar(obj);
                MessageBox.Show("Produto Deletado com Sucesso.");
                Listar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                Listar();
                return;
            }

            obj.Nome = textBox1.Text;
            obj.Codigo_sku = textBox4.Text;
            List<Produtos> lista = new List<Produtos>();
            lista = new Produto_Model().Buscar(obj);
            dtg_produtos.AutoGenerateColumns = false;
            dtg_produtos.DataSource = lista;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                Listar();
                return;
            }

            obj.Nome = textBox1.Text;
            obj.Codigo_sku = textBox4.Text;
            List<Produtos> lista = new List<Produtos>();
            lista = new Produto_Model().Buscar(obj);
            dtg_produtos.AutoGenerateColumns = false;
            dtg_produtos.DataSource = lista;
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            
        }

        public int Id_produto
        {
            get { return Convert.ToInt32(Tb_Id.Text); }
        }

        private void dtg_produtos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Tb_Id.Text = dtg_produtos.CurrentRow.Cells[0].Value.ToString();
            Tb_nome_select.Text = dtg_produtos.CurrentRow.Cells[1].Value.ToString();
            Tb_qtd_select.Text = dtg_produtos.CurrentRow.Cells[2].Value.ToString();
            Tb_ValCp_select.Text = dtg_produtos.CurrentRow.Cells[3].Value.ToString();
            Tb_ValVend_select.Text = dtg_produtos.CurrentRow.Cells[4].Value.ToString();
            Tb_ValLuc_select.Text = dtg_produtos.CurrentRow.Cells[5].Value.ToString();
            Tb_cod_select.Text = dtg_produtos.CurrentRow.Cells[7].Value.ToString();
        }
        
        private void dtg_produtos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void W_Produtos_Enter(object sender, EventArgs e)
        {
            Listar();
            return;
        }
    }
}
