using SST.Entities;
using SST.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace SST.View
{

    public partial class W_Cadastro_Vendas : Form
    {
        Produtos ObjP = new Produtos();
        Vendas Venda = new Vendas();
        Produtos_da_Venda ProdutoVenda = new Produtos_da_Venda();

        int ProxIdVenda;
        public W_Cadastro_Vendas()
        {
            int buscaid;
            InitializeComponent();
            buscaid = BuscaIdVenda();
            if (buscaid != 0)
            {
                ProxIdVenda = buscaid + 1;
                Tb_id_venda.Text = ProxIdVenda.ToString();
            }
            else
            {
                MessageBox.Show("Erro ao encontrar a numeração das Vendas");
            }
            ListarProdutos();
            ProdutoVenda.Id_venda = Convert.ToInt32(Tb_id_venda.Text);
            lista_produtos_venda(ProdutoVenda);
            Tb_qtd_itens.Text = "0";
            Tb_valor_compra.Text = "0";
            Tb_valor_custo_produtos.Text = "0";
        }
        public static DateTime Today { get; }

        private void W_Cadastro_Vendas_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sup;
            float sup2;
            ProdutoVenda.Id_produto = Convert.ToInt32(Tb_idprodt_selec.Text);
            ProdutoVenda.Id_venda   = Convert.ToInt32(Tb_id_venda.Text);
            ProdutoVenda.Produto    = Tb_produto_selec.Text;
            ProdutoVenda.Valor_custo_produto = Convert.ToSingle(tb_custo_produto_selec.Text);
            ProdutoVenda.Valor_venda_produto = Convert.ToSingle(Tb_ValVenda_produto_selec.Text);
            ProdutoVenda.Quantidade_produto = 1;
            InserirProdutoVenda(ProdutoVenda);
            lista_produtos_venda(ProdutoVenda);


            sup = (Convert.ToInt32(Tb_qtd_itens.Text));
            sup++;
            Tb_qtd_itens.Text = Convert.ToString(sup);

            sup2 = Convert.ToSingle(Tb_valor_compra.Text);
            sup2 += ProdutoVenda.Valor_venda_produto;

            Tb_valor_compra.Text = Convert.ToString(sup2);

            sup2 = Convert.ToSingle(Tb_valor_custo_produtos.Text);
            sup2 += ProdutoVenda.Valor_custo_produto;

            Tb_valor_custo_produtos.Text = Convert.ToString(sup2);

        }

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                ListarProdutos();
                return;
            }

            ObjP.Nome = textBox3.Text;
            List<Produtos> lista = new List<Produtos>();
            lista = new Produto_Model().Buscar(ObjP);
            dtg_lista_prod.AutoGenerateColumns = false;
            dtg_lista_prod.DataSource = lista;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListarProdutos();
        }

        public void ListarProdutos()
        {
            try
            {
                List<Produtos> lista = new List<Produtos>();
                lista = new Produto_Model().Listar();

                dtg_lista_prod.DataSource = lista;
                dtg_lista_prod.Columns[0].Visible = false;
                dtg_lista_prod.Columns[1].HeaderText = "Nome";
                dtg_lista_prod.Columns[1].Width = 385;
                dtg_lista_prod.Columns[2].Visible = false;
                dtg_lista_prod.Columns[3].Visible = false;
                dtg_lista_prod.Columns[4].Visible = false;
                dtg_lista_prod.Columns[5].Visible = false;
                dtg_lista_prod.Columns[6].Visible = false;
                dtg_lista_prod.Columns[7].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível listar os dados" + ex);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Tb_produto_selec.Text = dtg_lista_prod.CurrentRow.Cells[1].Value.ToString();
            Tb_idprodt_selec.Text = dtg_lista_prod.CurrentRow.Cells[0].Value.ToString();
            tb_custo_produto_selec.Text = dtg_lista_prod.CurrentRow.Cells[3].Value.ToString();
            Tb_ValVenda_produto_selec.Text = dtg_lista_prod.CurrentRow.Cells[4].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if ((Tb_cliente.Text != "") && (Tb_valor_compra.Text != "") && (Tb_valor_custo_produtos.Text != "") &&
               (Tb_qtd_itens.Text != "") && (Tb_id_venda.Text != ""))
            {
                salvar();
                Tb_cliente.Text = "";
                Tb_valor_compra.Text = "";
                Tb_valor_custo_produtos.Text = "";
                Tb_qtd_itens.Text = "";
                Tb_id_venda.Text = "";
            }
            else
            {
                MessageBox.Show("É necessario preencher todos os campos sobre a venda para cadastra-la");
            }
        }        

        private void salvar()
        {
            try
            {                
                Venda.Cliente = Tb_cliente.Text;
                Venda.Valor_compra = Convert.ToInt32(Tb_valor_compra.Text);
                Venda.Valor_custo_produtos = Convert.ToSingle(Tb_valor_custo_produtos.Text);
                Venda.Valor_lucro = Convert.ToInt32(Tb_valor_compra.Text) - Convert.ToSingle(Tb_valor_custo_produtos.Text);
                Venda.Situacao = Convert.ToInt32(Cb_situacao.SelectedItem);
                Venda.Forma_pagamento = Convert.ToInt32(Cb_forma_pag.SelectedItem); 
                Venda.Data_venda = Today;
                Venda.Local_compra = "Instagram";

                Vendas_Model.Inserir(Venda);
                MessageBox.Show("Inserido com Sucesso");
            }

            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro);
            }
        }

        private void lista_produtos_venda(Produtos_da_Venda obj)
        {
            try
            {
                List<Produtos_da_Venda> lista = new List<Produtos_da_Venda>();
                lista = new Produtos_da_Venda_Model().Listar(ProdutoVenda);

                dtg_lista_prod_venda.DataSource = lista;
                dtg_lista_prod_venda.Columns[0].Visible = false;
                dtg_lista_prod_venda.Columns[2].Visible = false;
                dtg_lista_prod_venda.Columns[6].Visible = false;
                dtg_lista_prod_venda.Columns[7].Visible = false;   
                
                dtg_lista_prod_venda.Columns[1].HeaderText = "Nome";
                dtg_lista_prod_venda.Columns[5].HeaderText = "Quantidade";
                dtg_lista_prod_venda.Columns[3].HeaderText = "Valor de custo";
                dtg_lista_prod_venda.Columns[4].HeaderText = "Valor venda";                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível listar os dados" + ex);
            }
        }
        private int BuscaIdVenda()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.SSTConnectionString;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "SELECT * FROM VENDAS WHERE id=(SELECT max(id) FROM VENDAS);";
                cn.Connection = con;

                SqlDataReader dr;

                dr = cn.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        int ProxId = Convert.ToInt32(dr["id"]);
                        return ProxId;
                    }
                }
                return 0;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            ProdutoVenda.Id_produto = Convert.ToInt32(Tb_idprodt_selec.Text);
            ProdutoVenda.Id_venda = Convert.ToInt32(Tb_id_venda.Text);
            DeletaProdutoVenda(ProdutoVenda);
        }

        private void DeletaProdutoVenda(Produtos_da_Venda ProdutoVenda)
        {
            try
            {
                ProdutoVenda.Id = Convert.ToInt32(Tb_idprodt_selec.Text);
                ProdutoVenda.Id_venda = Convert.ToInt32(Tb_id_venda.Text);
                Produtos_da_Venda_Model.Deletar(ProdutoVenda);
                MessageBox.Show("Produto Deletado com Sucesso.");
                lista_produtos_venda(ProdutoVenda);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro);
            }
        }

        private void dtg_lista_prod_venda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Tb_produto_selec.Text = dtg_lista_prod_venda.CurrentRow.Cells[1].Value.ToString();
            Tb_idprodt_selec.Text = dtg_lista_prod_venda.CurrentRow.Cells[0].Value.ToString();
        }

        private void InserirProdutoVenda(Produtos_da_Venda obj)
        {
            try
            {                
                Produtos_da_Venda_Model.Inserir(obj);
                MessageBox.Show("Produto inserido com Sucesso.");
                lista_produtos_venda(obj);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro);
            }
        }

        private void DT_data_venda_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtg_lista_prod_venda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtg_lista_prod_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
