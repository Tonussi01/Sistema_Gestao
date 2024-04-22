using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SST.Models;
using SST.Entities;

namespace SST.View
{
    public partial class W_Edicao_Venda : Form
    {
        Vendas obj = new Vendas();
        Produtos objP = new Produtos();
        Produtos_da_Venda ProdutoVenda = new Produtos_da_Venda();
        public W_Edicao_Venda(Vendas Venda)
        {
            InitializeComponent();
            Tb_id_venda.Text = Venda.Id.ToString();
            BuscaVenda(Venda.Id);
            Tb_cliente.Text = obj.Cliente.ToString();
            Tb_valor_compra.Text = obj.Valor_compra.ToString();
            Tb_valor_produtos.Text = obj.Valor_custo_produtos.ToString();
            Cb_Situacao.SelectedItem = obj.Situacao.ToString();
            Cb_forma_pag.SelectedItem = obj.Forma_pagamento.ToString();
            // DT_data_venda.Value = Convert.ToDateTime(obj.Data_venda.ToString());
            ProdutoVenda.Id_venda = Venda.Id;
            lista_produtos_venda(ProdutoVenda);
            ListarProdutos();
        }

        private void label1_Click(object sender, EventArgs e)
        {

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

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                ListarProdutos();
                return;
            }

            objP.Nome = textBox3.Text;
            List<Produtos> lista = new List<Produtos>();
            lista = new Produto_Model().Buscar(objP);
            Dtg_Produtos.AutoGenerateColumns = false;
            Dtg_Produtos.DataSource = lista;
        }

        private void Tb_qtd_itens_TextChanged(object sender, EventArgs e)
        {

        }

        private void Dtg_Produtos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BuscaVenda(int id)
        {
            List<Vendas> lista = new List<Vendas>();
            lista = new Vendas_Model().BuscarId(id);
            obj.Cliente = lista[0].Cliente;
            obj.Valor_compra = lista[0].Valor_compra;
            obj.Valor_custo_produtos = lista[0].Valor_custo_produtos;
            obj.Valor_lucro = lista[0].Valor_lucro;
            obj.Situacao = lista[0].Situacao;
            obj.Forma_pagamento = lista[0].Forma_pagamento;
            obj.Local_compra = lista[0].Local_compra;
            obj.Data_venda = lista[0].Data_venda;
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

        public void ListarProdutos()
        {
            try
            {
                List<Produtos> lista = new List<Produtos>();
                lista = new Produto_Model().Listar();

                Dtg_Produtos.DataSource = lista;
                Dtg_Produtos.Columns[0].Visible = false;
                Dtg_Produtos.Columns[1].HeaderText = "Nome";
                Dtg_Produtos.Columns[1].Width = 385;
                Dtg_Produtos.Columns[2].Visible = false;
                Dtg_Produtos.Columns[3].Visible = false;
                Dtg_Produtos.Columns[4].Visible = false;
                Dtg_Produtos.Columns[5].Visible = false;
                Dtg_Produtos.Columns[6].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível listar os dados" + ex);
            }
        }

        private void W_Edicao_Venda_Load(object sender, EventArgs e)
        {

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

        private void button2_Click(object sender, EventArgs e)
        {
           // int sup;
           // float sup2;
            ProdutoVenda.Id_produto = Convert.ToInt32(Tb_idprodt_selec.Text);
            ProdutoVenda.Id_venda = Convert.ToInt32(Tb_id_venda.Text);
            ProdutoVenda.Produto = Tb_produto_selec.Text;
            ProdutoVenda.Valor_custo_produto = Convert.ToSingle(tb_custo_produto_selec.Text);
            ProdutoVenda.Valor_venda_produto = Convert.ToSingle(Tb_ValVenda_produto_selec.Text);
            ProdutoVenda.Quantidade_produto = 1;
            InserirProdutoVenda(ProdutoVenda);
            lista_produtos_venda(ProdutoVenda);

           // sup = (Convert.ToInt32(Tb_qtd_itens.Text));
            //sup++;
            //Tb_qtd_itens.Text = Convert.ToString(sup);

           // sup2 = Convert.ToSingle(Tb_valor_compra.Text);
           // sup2 += ProdutoVenda.Valor_venda_produto;

           // Tb_valor_compra.Text = Convert.ToString(sup2);
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

        private void Dtg_Produtos_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            Tb_produto_selec.Text           = Dtg_Produtos.CurrentRow.Cells[1].Value.ToString();
            Tb_idprodt_selec.Text           = Dtg_Produtos.CurrentRow.Cells[0].Value.ToString();
            tb_custo_produto_selec.Text     = Dtg_Produtos.CurrentRow.Cells[3].Value.ToString();
            Tb_ValVenda_produto_selec.Text  = Dtg_Produtos.CurrentRow.Cells[4].Value.ToString();
        }

        private void dtg_lista_prod_venda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Tb_produto_selec.Text           = dtg_lista_prod_venda.CurrentRow.Cells[1].Value.ToString();
            Tb_idprodt_selec.Text           = dtg_lista_prod_venda.CurrentRow.Cells[0].Value.ToString();
            tb_custo_produto_selec.Text     = dtg_lista_prod_venda.CurrentRow.Cells[3].Value.ToString();
            Tb_ValVenda_produto_selec.Text  = dtg_lista_prod_venda.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
