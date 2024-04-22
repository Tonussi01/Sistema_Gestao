using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SST.Controllers;
using SST.Entities;

namespace SST.Models
{
    class Produtos_da_Venda_Model
    {
        public static int Inserir(Produtos_da_Venda obj)
        {
            return new Produtos_da_Venda_Controller().InserirProdutoDaVenda(obj);
        }

        //Não Utilizado
        public static int Editar(Produtos_da_Venda obj)
        {
            return new Produtos_da_Venda_Controller().EditarProdutoDaVenda(obj);
        }

        public static int Deletar(Produtos_da_Venda obj)
        {
            return new Produtos_da_Venda_Controller().DeletarProdutoDaVenda(obj);
        }

        public static int DeletarVenda(Produtos_da_Venda obj)
        {
            return new Produtos_da_Venda_Controller().DeletarTodosProdutosDaVenda(obj);
        }

        public List<Produtos_da_Venda> Listar(Produtos_da_Venda obj)
        {
            return new Produtos_da_Venda_Controller().ListarProdutosDaVenda(obj);
        }

        
    }
}
