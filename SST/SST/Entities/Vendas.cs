using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SST.Entities
{
    public class Vendas
    {
        int id;
        string cliente;
        float valor_compra;
        float valor_custo_produtos;
        float valor_lucro;
        int situacao;
        int forma_pagamento;
        string local_compra;
        DateTime data_venda;

        public int Id { get => id; set => id = value; }
        public string Cliente { get => cliente; set => cliente = value; }
        public float Valor_compra { get => valor_compra; set => valor_compra = value; }
        public float Valor_custo_produtos { get => valor_custo_produtos; set => valor_custo_produtos = value; }
        public float Valor_lucro { get => valor_lucro; set => valor_lucro = value; }
        public int Situacao { get => situacao; set => situacao = value; }
        public int Forma_pagamento { get => forma_pagamento; set => forma_pagamento = value; }
        public string Local_compra { get => local_compra; set => local_compra = value; }

        public DateTime Data_venda { get => data_venda; set => data_venda = value; }
}
}
