using System;
using System.Windows.Forms;
using SST.Models;
using SST.Entities;

namespace SST.View
{
    public partial class W_Edicao_Produto : Form
    {        
        Produtos obj = new Produtos();
        int id_prod_edicao;

        public W_Edicao_Produto(Produtos obj)
        {
            InitializeComponent();
            id_prod_edicao = obj.Id;
            TB_nome.Text = obj.Nome.ToString();
            TB_qtd.Text = obj.Quantidade.ToString();
            TB_val_compra.Text = obj.Valor_compra.ToString();
            TB_val_venda.Text = obj.Valor_venda.ToString();
            TB_val_lucro.Text = obj.Valor_lucro.ToString();
            TB_cod_sku.Text = obj.Codigo_sku.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                obj.Id = id_prod_edicao;
                obj.Nome = Convert.ToString(TB_nome.Text);
                obj.Quantidade = Convert.ToInt32(TB_qtd.Text);
                obj.Valor_compra = Convert.ToSingle(TB_val_compra.Text);
                obj.Valor_venda = Convert.ToSingle(TB_val_venda.Text);
                obj.Valor_lucro = Convert.ToSingle(TB_val_lucro.Text);
                obj.Codigo_sku = Convert.ToString(TB_cod_sku.Text);
                Produto_Model.Editar(obj);
                MessageBox.Show("Editado com Sucesso");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível listar os dados" + ex);
            }      
        }

        private void W_Edicao_Produto_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
