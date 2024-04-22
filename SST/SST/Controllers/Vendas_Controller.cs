using SST.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SST.Controllers
{
    class Vendas_Controller
    {
        public int InserirVenda(Vendas obj)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.SSTConnectionString;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = System.Data.CommandType.Text;
                con.Open();
                cn.CommandText = "INSERT INTO VENDAS ([cliente],[valor_compra],[valor_custo_produtos],[valor_lucro],[situacao]" +
                                 ",[forma_pagamento],[local_compra],[data_venda])" +
                                 " VALUES (@Cliente, @Valor_compra, @Valor_custo_produtos, @Valor_lucro, @Situacao, @Forma_pagamento, @Local_compra, @Data_venda)";
                cn.Parameters.Add("cliente", System.Data.SqlDbType.VarChar).Value = obj.Cliente;
                cn.Parameters.Add("valor_compra", System.Data.SqlDbType.Decimal).Value = obj.Valor_compra;
                cn.Parameters.Add("valor_custo_produtos", System.Data.SqlDbType.Decimal).Value = obj.Valor_custo_produtos;
                cn.Parameters.Add("valor_lucro", System.Data.SqlDbType.Decimal).Value = obj.Valor_lucro;
                cn.Parameters.Add("situacao", System.Data.SqlDbType.Int).Value = obj.Situacao;
                cn.Parameters.Add("forma_pagamento", System.Data.SqlDbType.VarChar).Value = obj.Forma_pagamento;
                cn.Parameters.Add("local_compra", System.Data.SqlDbType.VarChar).Value = obj.Local_compra;
                cn.Parameters.Add("data_venda", System.Data.SqlDbType.VarChar).Value = obj.Data_venda;
                cn.Connection = con;

                int tst = cn.ExecuteNonQuery();
                return tst;

            }
        }

        public List<Vendas> BuscarVendas(Vendas obj)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.SSTConnectionString;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                obj.Cliente = '%' + obj.Cliente + '%';
                cn.CommandText = "SELECT id, cliente, valor_compra, valor_custo_produtos, valor_lucro, situacao, forma_pagamento,local_compra,data_venda " +
                                 "    FROM VENDAS WHERE (cliente LIKE  @Cliente )";
                cn.Parameters.Add("Cliente", SqlDbType.VarChar).Value = obj.Cliente;
                cn.Connection = con;

                SqlDataReader dr;
                List<Vendas> ListaVendas = new List<Vendas>();
                dr = cn.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Vendas Venda = new Vendas();
                        Venda.Id = Convert.ToInt32(dr["id"]);
                        Venda.Cliente = Convert.ToString(dr["cliente"]);
                        Venda.Valor_compra = Convert.ToSingle(dr["valor_compra"]);
                        Venda.Valor_custo_produtos = Convert.ToSingle(dr["valor_custo_produtos"]);
                        Venda.Valor_lucro = Convert.ToSingle(dr["valor_lucro"]);
                        Venda.Situacao = Convert.ToInt32(dr["situacao"]);
                        Venda.Forma_pagamento = Convert.ToInt32(dr["forma_pagamento"]);
                        Venda.Local_compra = Convert.ToString(dr["local_compra"]);
                        Venda.Data_venda = Convert.ToDateTime(dr["data_venda"]);

                        ListaVendas.Add(Venda);
                    }
                }
                return ListaVendas;
            }
        }

        public List<Vendas> BuscarVendasId(int Id)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.SSTConnectionString;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "SELECT id, cliente, valor_compra, valor_custo_produtos, valor_lucro, situacao, forma_pagamento,local_compra,data_venda " +
                                 "    FROM VENDAS WHERE (id =  @Id )";
                cn.Parameters.Add("id", SqlDbType.Int).Value = Id;
                cn.Connection = con;

                SqlDataReader dr;
                List<Vendas> ListaVendas = new List<Vendas>();
                dr = cn.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Vendas Venda = new Vendas();
                        Venda.Id = Convert.ToInt32(dr["id"]);
                        Venda.Cliente = Convert.ToString(dr["cliente"]);
                        Venda.Valor_compra = Convert.ToSingle(dr["valor_compra"]);
                        Venda.Valor_custo_produtos = Convert.ToSingle(dr["valor_custo_produtos"]);
                        Venda.Valor_lucro = Convert.ToSingle(dr["valor_lucro"]);
                        Venda.Situacao = Convert.ToInt32(dr["situacao"]);
                        Venda.Forma_pagamento = Convert.ToInt32(dr["forma_pagamento"]);
                        Venda.Local_compra = Convert.ToString(dr["local_compra"]);
                        Venda.Data_venda = Convert.ToDateTime(dr["data_venda"]);

                        ListaVendas.Add(Venda);
                        return ListaVendas;
                    }
                }

                return ListaVendas;

            }
        }



        public List<Vendas> ListarVendas()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.SSTConnectionString;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "SELECT id, cliente, valor_compra, valor_custo_produtos, valor_lucro, situacao, forma_pagamento,local_compra,data_venda FROM VENDAS";
                cn.Connection = con;

                SqlDataReader dr;
                List<Vendas> ListaVendas = new List<Vendas>();
                dr = cn.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Vendas Venda = new Vendas();
                        Venda.Id = Convert.ToInt32(dr["id"]);
                        Venda.Cliente = Convert.ToString(dr["cliente"]);
                        Venda.Valor_compra = Convert.ToSingle(dr["valor_compra"]);
                        Venda.Valor_custo_produtos = Convert.ToSingle(dr["valor_custo_produtos"]);
                        Venda.Valor_lucro = Convert.ToSingle(dr["valor_lucro"]);
                        Venda.Situacao = Convert.ToInt32(dr["situacao"]);
                        Venda.Forma_pagamento = Convert.ToInt32(dr["forma_pagamento"]);
                        Venda.Local_compra = Convert.ToString(dr["local_compra"]);
                        Venda.Data_venda = Convert.ToDateTime(dr["data_venda"]);

                        ListaVendas.Add(Venda);
                    }
                }
                return ListaVendas;

            }
        }
        public int DeletaVenda(Vendas obj)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.SSTConnectionString;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "DELETE FROM Vendas where id = @id";

                cn.Parameters.Add("id", SqlDbType.Int).Value = obj.Id;
                cn.Connection = con;


                int qtd = cn.ExecuteNonQuery();
                return qtd;
            }
        }
    }
}
