using SST.Controllers;
using SST.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SST.Models
{
    class Vendas_Model
    {      
        public static int Inserir(Vendas obj)
        {
            return new Vendas_Controller().InserirVenda(obj);
        }

        public List<Vendas> Buscar(Vendas obj)
        {
            return new Vendas_Controller().BuscarVendas(obj);
        }
        public List<Vendas> BuscarId(int id)
        {
            return new Vendas_Controller().BuscarVendasId(id);
        }

        public List<Vendas> Listar()
        {
            return new Vendas_Controller().ListarVendas();
        }
        public static int Deletar(Vendas obj)
        {
            return new Vendas_Controller().DeletaVenda(obj);
        }

    }
}
