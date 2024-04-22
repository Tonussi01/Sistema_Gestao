using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SST.Models;
using SST.Entities;

namespace SST.View
{
    public partial class W_Vendas : Form
    {
        Vendas obj = new Vendas();
        Produtos objP = new Produtos();
        Produtos_da_Venda ObjPV = new Produtos_da_Venda();

        public W_Vendas()
        {
            InitializeComponent();
            ListarVendas();
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            W_Cadastro_Vendas form = new W_Cadastro_Vendas();
            form.Show();
        }

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public int Id_venda
        {
            get { return Convert.ToInt32(Tb_id_venda_selec.Text); }//tb_id_venda ***
        }

        private void button3_Click(object sender, EventArgs e)
        {
            obj.Id = Convert.ToInt32(Tb_id_venda_selec.Text);
            W_Edicao_Venda form = new W_Edicao_Venda(obj);
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DeletaVenda();
        }
        private void DeletaVenda()
        {
            
            try
            {
                obj.Id = Convert.ToInt32(Tb_id_venda_selec.Text);
                ObjPV.Id_venda = Convert.ToInt32(Tb_id_venda_selec.Text);
                Vendas_Model.Deletar(obj);
                Produtos_da_Venda_Model.DeletarVenda(ObjPV);
                MessageBox.Show("Produto Deletado com Sucesso.");
                ListarVendas();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                ListarVendas();
                return;
            }

            obj.Cliente = textBox1.Text;
            List<Vendas> lista = new List<Vendas>();
            lista = new Vendas_Model().Buscar(obj);
            dtg_Vendas.AutoGenerateColumns = false;
            dtg_Vendas.DataSource = lista;
        }
        public void ListarVendas()
        {
            try
            {
                List<Vendas> lista = new List<Vendas>();
                lista = new Vendas_Model().Listar();

                dtg_Vendas.DataSource = lista;
                dtg_Vendas.Columns[0].Visible = false;
                dtg_Vendas.Columns[1].HeaderText = "Cliente";
                dtg_Vendas.Columns[1].Width = 250;
                dtg_Vendas.Columns[2].HeaderText = "Valor de Compra";
                dtg_Vendas.Columns[3].HeaderText = "Valor de Custo";
                dtg_Vendas.Columns[4].HeaderText = "Valor de Lucro";
                dtg_Vendas.Columns[5].HeaderText = "Situação";
                dtg_Vendas.Columns[6].HeaderText = "Forma de Pagamento";
                dtg_Vendas.Columns[7].HeaderText = "Local da Compra";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível listar os dados" + ex);
            }                       
        }

        private void W_Vendas_Load(object sender, EventArgs e)
        {

        }

        private void dtg_Vendas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Tb_id_venda_selec.Text = dtg_Vendas.CurrentRow.Cells[0].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            obj.Id = Convert.ToInt32(Tb_id_venda_selec.Text);
            W_Detalhe_Vendas form = new W_Detalhe_Vendas(obj);
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
