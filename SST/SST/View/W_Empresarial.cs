using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace SST.View
{
    public partial class W_Empresarial : Form
    {
        float Lucro_Total, Valor_Total_Estoque, Valor_Caixa, Valor_Shopee, Valor_Cartao, Previsao_Lucro_Total, Gasto_Frete;
        String NomeEmpresa, Endereco, Telefone, Cnpj, Instagran, Shopee, Desenvolvedor;

        public W_Empresarial()
        {
            InitializeComponent();
            RecuperaDadosEmpresarial();
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

        private void W_Financeiro_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void RecuperaDadosEmpresarial()
        {
            
            BuscaLucro();
            Tb_lucro_total.Text = "R$ " + Lucro_Total.ToString();
            BuscaTotalEstoque();
            Tb_valor_estoque.Text = "R$ " + Valor_Total_Estoque.ToString();
            BuscaPrevisaoLucro();
            Tb_lucroT.Text = "R$ " + Previsao_Lucro_Total.ToString();
            BuscaEmpresarial();
            Tb_nome_empresa.Text         = NomeEmpresa  ;
            Tb_endereco.Text = Endereco     ;
            Tb_telefone_empresa.Text = Telefone     ;
            Tb_loja_shopee.Text = Shopee       ;
            Tb_loja_instagram.Text = Instagran    ;
            Tb_proprietario_loja.Text = Desenvolvedor;
            Tb_gasto_frete.Text = "R$ " + Gasto_Frete.ToString();
            Tb_receber_cartao.Text = "R$ " + Valor_Cartao.ToString();
            Tb_receber_shopee.Text = "R$ " + Valor_Shopee.ToString();
            Tb_valor_caixa.Text = "R$ " + Valor_Caixa.ToString();
        }

        private int BuscaLucro()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.SSTConnectionString;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "select sum(valor_lucro) as Lucro from vendas";
                cn.Connection = con;

                SqlDataReader dr;

                dr = cn.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Lucro_Total = Convert.ToSingle(dr["Lucro"]);
                    }
                }
                return 0;
            }        
        }

        private int BuscaTotalEstoque()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.SSTConnectionString;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "select sum(valor_compra * quantidade ) as TotalEstoque from Produtos";
                cn.Connection = con;

                SqlDataReader dr;

                dr = cn.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Valor_Total_Estoque = Convert.ToSingle(dr["TotalEstoque"]);
                    }
                }
                return 0;
            }

        }

        private int BuscaPrevisaoLucro()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.SSTConnectionString;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "select sum(valor_lucro * quantidade ) as PrevisaoLucro from Produtos";
                cn.Connection = con;

                SqlDataReader dr;

                dr = cn.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Previsao_Lucro_Total = Convert.ToSingle(dr["PrevisaoLucro"]);
                    }
                }
                return 0;
            }

        }
        private int BuscaEmpresarial()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.SSTConnectionString;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "select * from EMPRESARIAL";
                cn.Connection = con;

                SqlDataReader dr;

                dr = cn.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Valor_Caixa         = Convert.ToSingle(dr["Valor_Caixa"]);
                        Valor_Shopee        = Convert.ToSingle(dr["Valor_Shopee"]);
                        Valor_Cartao        = Convert.ToSingle(dr["Valor_Cartao"]);
                        Gasto_Frete         = Convert.ToSingle(dr["Gasto_Frete"]);
                        NomeEmpresa         = Convert.ToString(dr["NomeEmpresa"]);
                        Endereco            = Convert.ToString(dr["Endereco"]);
                        Telefone            = Convert.ToString(dr["Telefone"]);
                        Cnpj                = Convert.ToString(dr["Cnpj"]);
                        Instagran           = Convert.ToString(dr["Instagran"]);
                        Shopee              = Convert.ToString(dr["Shopee"]);
                        Desenvolvedor       = Convert.ToString(dr["Desenvolvedor"]);
                    }
                }
                return 0;
            }

        }


    }
}
