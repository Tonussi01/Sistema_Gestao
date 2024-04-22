using SST.Entities;
using SST.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SST.View
{
    public partial class W_Detalhe_Vendas : Form
    {
        Produtos_da_Venda ProdutoVenda = new Produtos_da_Venda();
        Vendas ObjV = new Vendas();
        public W_Detalhe_Vendas(Vendas Venda)
        {
            BuscaVenda(Venda.Id);
            InitializeComponent();     

            ProdutoVenda.Id_venda = Venda.Id;

            TB_Cliente.Text = ObjV.Cliente;
            TB_ValorVenda.Text = ObjV.Valor_compra.ToString();            

            TB_CustoProdutos.Text = ObjV.Valor_custo_produtos.ToString();
            TB_Lucro.Text = ObjV.Valor_lucro.ToString();

            lista_produtos_venda(ProdutoVenda);
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

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void TB_ValorVenda_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void TB_Situacao_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void W_Detalhe_Vendas_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TB_Lucro_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void TB_CustoProdutos_TextChanged(object sender, EventArgs e)
        {

        }

        private void TB_Cliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void TB_LocalVenda_TextChanged(object sender, EventArgs e)
        {

        }

        private void TB_FormaPagamento_TextChanged(object sender, EventArgs e)
        {

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

                dtg_lista_prod_venda.Columns[1].HeaderText = "Produto";
                dtg_lista_prod_venda.Columns[1].Width = 640;
                dtg_lista_prod_venda.Columns[5].HeaderText = "Quantidade";
                dtg_lista_prod_venda.Columns[3].HeaderText = "Valor de custo";
                dtg_lista_prod_venda.Columns[4].HeaderText = "Valor venda";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível listar os dados" + ex);
            }
        }

        private void BuscaVenda(int id)
        {
            List<Vendas> lista = new List<Vendas>();
            lista = new Vendas_Model().BuscarId(id);
            ObjV.Cliente = lista[0].Cliente;
            ObjV.Valor_compra = lista[0].Valor_compra;
            ObjV.Valor_custo_produtos = lista[0].Valor_custo_produtos;
            ObjV.Valor_lucro = lista[0].Valor_lucro;
            ObjV.Situacao = lista[0].Situacao;
            ObjV.Forma_pagamento = lista[0].Forma_pagamento;
            ObjV.Local_compra = lista[0].Local_compra;
            ObjV.Data_venda = lista[0].Data_venda;                        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ObjV.Id = ProdutoVenda.Id_venda;
            W_Edicao_Venda form = new W_Edicao_Venda(ObjV);
            form.Show();
        }
    }
}
