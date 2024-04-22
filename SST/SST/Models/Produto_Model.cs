using SST.Controllers;
using SST.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SST.Models
{
    public class Produto_Model
    {
        public static int Inserir(Produtos obj)
        {
            return new Produtos_Controller().InserirProduto(obj);
        }

        public static int Editar(Produtos obj)
        {
            return new Produtos_Controller().EditarProduto(obj);
        }

        public static int Deletar(Produtos obj)
        {
            return new Produtos_Controller().DeletarProduto(obj);
        }

        public List<Produtos> Buscar(Produtos obj)
        {
            return new Produtos_Controller().BuscarProduto(obj);
        }

        public List<Produtos> Listar()
        {
            return new Produtos_Controller().ListarProduto();
        }
    }
}
