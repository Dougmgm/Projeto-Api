using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Projeto_API.Context;
using Projeto_API.Models;

namespace Projeto_API.Repository
{
    public class ItemPedidoRepository
    {
        private readonly VendasContext _context;
        public ItemPedidoRepository(VendasContext context)
        {
            _context = context;
        }

         public void Cadastrar(ItemPedido itemPedido)
        {
            _context.ItemPedidos.Add(itemPedido);
            _context.SaveChanges();
        }

        public ItemPedido ObterPorId(int id)
        {
            var itemPedido = _context.ItemPedidos.Find(id);
            return itemPedido;
        }

    }
}