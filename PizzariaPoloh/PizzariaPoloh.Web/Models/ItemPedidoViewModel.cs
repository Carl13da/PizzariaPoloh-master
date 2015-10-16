using System;
using System.ComponentModel.DataAnnotations;

namespace PizzariaPoloh.Web.Models
{
    public class ItemPedidoViewModel
    {
        [Range(1, Int32.MaxValue)]
        public int ProdutoId { get; set; }
        [Range(1, Int32.MaxValue)]
        public int Quantidade { get; set; }
    }
}