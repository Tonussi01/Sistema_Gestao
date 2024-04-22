using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SST.Entities
{
    public class Produtos_da_Venda
    {
        int id;
        string produto;
        int id_produto;
        float valor_custo_produto;
        float valor_venda_produto;
        int quantidade_produto;
        int id_venda;
        DateTime data_venda;

        public int Id { get => id; set => id = value; }
        public string Produto { get => produto; set => produto = value; }
        public int Id_produto { get => id_produto; set => id_produto = value; }
        public float Valor_custo_produto { get => valor_custo_produto; set => valor_custo_produto = value; }
        public float Valor_venda_produto { get => valor_venda_produto; set => valor_venda_produto = value; }
        public int Quantidade_produto { get => quantidade_produto; set => quantidade_produto = value; }

        public int Id_venda { get => id_venda; set => id_venda = value; }

        public DateTime Data_venda { get => data_venda; set => data_venda = value; }

    }
}
