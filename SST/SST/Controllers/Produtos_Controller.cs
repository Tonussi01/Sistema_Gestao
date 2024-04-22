using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SST.Entities;
using SST.Models;

namespace SST.Controllers
{
    public class Produtos_Controller
    {
        public int InserirProduto(Produtos obj)
        {
            using(SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.SSTConnectionString;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = System.Data.CommandType.Text;
                con.Open();
                cn.CommandText = "INSERT INTO PRODUTOS ([nome],[quantidade],[valor_compra],[valor_venda],[valor_lucro],[codigo_sku])" +
                                 " VALUES (@nome, @Quantidade, @Valor_compra, @Valor_venda, @Valor_lucro, @Codigo_sku)";
                cn.Parameters.Add("nome", System.Data.SqlDbType.VarChar).Value = obj.Nome;
                cn.Parameters.Add("quantidade", System.Data.SqlDbType.Int).Value = obj.Quantidade;
                cn.Parameters.Add("valor_compra", System.Data.SqlDbType.Decimal).Value = obj.Valor_compra;
                cn.Parameters.Add("valor_venda", System.Data.SqlDbType.Decimal).Value = obj.Valor_venda;
                cn.Parameters.Add("valor_lucro", System.Data.SqlDbType.Decimal).Value = obj.Valor_lucro;
                cn.Parameters.Add("codigo_sku", System.Data.SqlDbType.VarChar).Value = obj.Codigo_sku;
                cn.Connection = con;

                int tst = cn.ExecuteNonQuery();
                return tst;
            }
        }

        public List<Produtos> BuscarProduto(Produtos obj)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.SSTConnectionString;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                obj.Nome = '%' + obj.Nome + '%';
                obj.Codigo_sku = '%' + obj.Codigo_sku + '%';
                cn.CommandText = "SELECT id, nome, quantidade, valor_compra, valor_venda, valor_lucro, codigo_sku " +
                                 "FROM PRODUTOS WHERE (nome LIKE  @nome ) AND (codigo_sku like @codigosku)";
                cn.Parameters.Add("nome", SqlDbType.VarChar).Value = obj.Nome;
                cn.Parameters.Add("codigosku", SqlDbType.VarChar).Value = obj.Codigo_sku;
                cn.Connection = con;

                SqlDataReader dr;
                List<Produtos> lista = new List<Produtos>();
                dr = cn.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Produtos produto = new Produtos();
                        produto.Id = Convert.ToInt32(dr["id"]);
                        produto.Nome = Convert.ToString(dr["nome"]);
                        produto.Quantidade = Convert.ToInt32(dr["quantidade"]);
                        produto.Valor_compra = Convert.ToSingle(dr["valor_compra"]);
                        produto.Valor_venda = Convert.ToSingle(dr["valor_venda"]);
                        produto.Valor_lucro = Convert.ToSingle(dr["valor_lucro"]);
                        produto.Codigo_sku = Convert.ToString(dr["codigo_sku"]);

                        lista.Add(produto);
                    }
                }
                return lista;
            }
        }

       

        public List<Produtos> ListarProduto()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.SSTConnectionString;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "SELECT id,nome,quantidade,valor_compra,valor_venda,valor_lucro,codigo_sku FROM PRODUTOS";
                cn.Connection = con;

                SqlDataReader dr;

                List<Produtos> lista = new List<Produtos>();


                dr = cn.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Produtos dado  = new Produtos();
                        dado.Id = Convert.ToInt32(dr["id"]);
                        dado.Nome = Convert.ToString(dr["nome"]);
                        dado.Quantidade = Convert.ToInt32(dr["quantidade"]);
                        dado.Valor_compra = Convert.ToSingle(dr["valor_compra"]);
                        dado.Valor_venda = Convert.ToSingle(dr["valor_venda"]);
                        dado.Valor_lucro = Convert.ToSingle(dr["valor_lucro"]);
                        dado.Codigo_sku = Convert.ToString(dr["codigo_sku"]);
                        
                        lista.Add(dado);
                    }
                }
                return lista;
            }
        }

        public int EditarProduto(Produtos obj)
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
                cn.Parameters.Add("nome", System.Data.SqlDbType.VarChar).Value = obj.Nome;
                cn.Parameters.Add("quantidade", System.Data.SqlDbType.Int).Value = obj.Quantidade;
                cn.Parameters.Add("valor_compra", System.Data.SqlDbType.Decimal).Value = obj.Valor_compra;
                cn.Parameters.Add("valor_venda", System.Data.SqlDbType.Decimal).Value = obj.Valor_venda;
                cn.Parameters.Add("valor_lucro", System.Data.SqlDbType.Decimal).Value = obj.Valor_lucro;
                cn.Parameters.Add("codigo_sku", System.Data.SqlDbType.VarChar).Value = obj.Codigo_sku;
                cn.Parameters.Add("disponivel", System.Data.SqlDbType.Int).Value = 1 ;

                cn.Connection = con;


                int qtd = cn.ExecuteNonQuery();
                return qtd;
            }
        }


        public int DeletarProduto(Produtos obj)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.SSTConnectionString;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "DELETE FROM PRODUTOS where id = @id";

                cn.Parameters.Add("id", SqlDbType.Int).Value = obj.Id;
                cn.Connection = con;


                int qtd = cn.ExecuteNonQuery();
                return qtd;
            }
        }

    }
}
