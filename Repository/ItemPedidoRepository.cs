using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Projeto_API.Context;
using Projeto_API.Dto;
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
            var itemPedido = _context.ItemPedidos.Include(x => x.Pedido)
                                                 .Include(x => x.Servico)
                                                 .FirstOrDefault(x => x.Id == id);
            return itemPedido;
        }


        public List <ObterItemPedidoDTO> ObterPorPedidoId(int pedidoId)
        {
            var itemPedido = _context.ItemPedidos.Where(x => x.PedidoId == pedidoId)
                                                .Select(x => new ObterItemPedidoDTO(x))
                                                .ToList();
            return itemPedido;
        }

        public ItemPedido ObterPorServicoId(int servicoId)
        {
            var itemPedido = _context.ItemPedidos.Find(servicoId);
            return itemPedido;
        }

        public ItemPedido AtualizarItemPedido(ItemPedido itemPedido)
        {
            _context.ItemPedidos.Update(itemPedido);
            _context.SaveChanges();
            return itemPedido;
        }

        public void DeletarItemPedido(ItemPedido itemPedido)
        {
            _context.ItemPedidos.Remove(itemPedido);
            _context.SaveChanges();
        }

        public List<ItemPedido> Listar()
        {
            return _context.ItemPedidos.ToList();
        }
    }
}