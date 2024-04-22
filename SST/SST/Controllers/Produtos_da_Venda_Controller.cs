using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SST.Controllers;
using SST.Entities;
using SST.Models;
using System.Data;
using System.Data.SqlClient;

namespace SST.Controllers
{
    class Produtos_da_Venda_Controller
    {
        public int InserirProdutoDaVenda(Produtos_da_Venda obj)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.SSTConnectionString;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = System.Data.CommandType.Text;
                con.Open();
                cn.CommandText = "INSERT INTO PRODUTOS_VENDA ([produto],[id_produto],[valor_custo_produto],[valor_venda_produto],[quantidade]," +
                    "[id_venda],[data_venda]) VALUES (@produto, @id_produto, @valor_custo_produto, @valor_venda_produto, @quantidade, @id_venda," +
                    "@data_venda)";
                cn.Parameters.Add("produto", System.Data.SqlDbType.VarChar).Value = obj.Produto;
                cn.Parameters.Add("id_produto", System.Data.SqlDbType.Int).Value = obj.Id_produto;
                cn.Parameters.Add("valor_custo_produto", System.Data.SqlDbType.Decimal).Value = obj.Valor_custo_produto;
                cn.Parameters.Add("valor_venda_produto", System.Data.SqlDbType.Decimal).Value = obj.Valor_venda_produto;
                cn.Parameters.Add("quantidade_produto", System.Data.SqlDbType.Int).Value = obj.Quantidade_produto;
                cn.Parameters.Add("id_venda", System.Data.SqlDbType.Int).Value = obj.Id_venda;
                cn.Parameters.Add("data_venda", System.Data.SqlDbType.Date).Value = obj.Data_venda;
                cn.Parameters.Add("quantidade", System.Data.SqlDbType.Int).Value = obj.Quantidade_produto;
                cn.Connection = con;

                int tst = cn.ExecuteNonQuery();
                return tst;
            }
        }


        public List<Produtos_da_Venda> ListarProdutosDaVenda(Produtos_da_Venda obj)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.SSTConnectionString;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "SELECT id,produto,id_produto,valor_custo_produto,valor_venda_produto,quantidade,id_venda,data_venda" +
                    "            FROM PRODUTOS_VENDA WHERE id_venda = @idVenda";
                cn.Parameters.Add("idVenda", System.Data.SqlDbType.Int).Value = obj.Id_venda;

                cn.Connection = con;

                SqlDataReader dr;

                List<Produtos_da_Venda> lista = new List<Produtos_da_Venda>();


                dr = cn.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Produtos_da_Venda dado = new Produtos_da_Venda();
                        dado.Id = Convert.ToInt32(dr["id"]);
                        dado.Produto = Convert.ToString(dr["produto"]);
                        dado.Id_produto = Convert.ToInt32(dr["id_produto"]);
                        dado.Valor_custo_produto = Convert.ToSingle(dr["valor_custo_produto"]);
                        dado.Valor_venda_produto = Convert.ToSingle(dr["valor_venda_produto"]);
                        dado.Quantidade_produto = Convert.ToInt32(dr["quantidade"]);
                        dado.Id_venda = Convert.ToInt32(dr["id_venda"]);
                        dado.Data_venda = Convert.ToDateTime(dr["data_venda"]);

                        lista.Add(dado);
                    }
                }
                return lista;
            }
        }

        public int EditarProdutoDaVenda(Produtos_da_Venda obj)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.SSTConnectionString;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "UPDATE PRODUTOS SET nome = @nome , quantidade = @quantidade, valor_compra = @valor_compra," +
                                 " valor_venda = @valor_venda , valor_lucro = @valor_lucro , codigo_sku = @codigo_sku , disponivel = @disponivel WHERE id = @id";
                cn.Parameters.Add("id", System.Data.SqlDbType.Int).Value = obj.Id;
                cn.Parameters.Add("produto", System.Data.SqlDbType.VarChar).Value = obj.Produto;
                cn.Parameters.Add("id_produto", System.Data.SqlDbType.Int).Value = obj.Id_produto;
                cn.Parameters.Add("valor_custo_produto", System.Data.SqlDbType.Decimal).Value = obj.Valor_custo_produto;
                cn.Parameters.Add("valor_venda_produto", System.Data.SqlDbType.Decimal).Value = obj.Valor_venda_produto;
                cn.Parameters.Add("quantidade", System.Data.SqlDbType.Decimal).Value = obj.Quantidade_produto;
                cn.Parameters.Add("id_venda", System.Data.SqlDbType.VarChar).Value = obj.Id_venda;
                cn.Parameters.Add("data_venda", System.Data.SqlDbType.VarChar).Value = obj.Data_venda;
                cn.Parameters.Add("disponivel", System.Data.SqlDbType.Int).Value = 1;

                cn.Connection = con;


                int qtd = cn.ExecuteNonQuery();
                return qtd;
            }
        }


        public int DeletarProdutoDaVenda(Produtos_da_Venda obj)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.SSTConnectionString;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "DELETE FROM PRODUTOS_VENDA where (id_venda like @idVenda and id = @Id)";
                cn.Parameters.Add("Id", SqlDbType.Int).Value = obj.Id;
                cn.Parameters.Add("idVenda", System.Data.SqlDbType.Int).Value = obj.Id_venda;

                cn.Connection = con;


                int qtd = cn.ExecuteNonQuery();
                return qtd;
            }
        }

        public int DeletarTodosProdutosDaVenda(Produtos_da_Venda obj)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.SSTConnectionString;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "DELETE FROM PRODUTOS_VENDA where (id_venda like @idVenda)";
                cn.Parameters.Add("idVenda", System.Data.SqlDbType.Int).Value = obj.Id_venda;

                cn.Connection = con;


                int qtd = cn.ExecuteNonQuery();
                return qtd;
            }
        }

    }
    
}
