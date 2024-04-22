using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SST.Entities
{
    public class Produtos
    {
        int     id;
        string  nome;
        int     quantidade;
        float   valor_compra;
        float   valor_venda;
        float   valor_lucro;
        int     disponivel;
        string  codigo_sku;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public int Quantidade { get => quantidade; set => quantidade = value; }
        public float Valor_compra { get => valor_compra; set => valor_compra = value; }
        public float Valor_venda { get => valor_venda; set => valor_venda = value; }
        public float Valor_lucro { get => valor_lucro; set => valor_lucro = value; }
        public int Disponivel { get => disponivel; set => disponivel = value; }
        public string Codigo_sku { get => codigo_sku; set => codigo_sku = value; }
    }
}
