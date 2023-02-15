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
    public class PedidoRepository 
    {
        private readonly VendasContext _context;
        public PedidoRepository(VendasContext context)
        {
            _context = context;
        }

        public Pedido Cadastrar(Pedido pedido)
        {
            _context.Pedidos.Add(pedido);
            _context.SaveChanges();
            return pedido;
        }

        public Pedido ObterPorId(int id)
        {
            var pedido = _context.Pedidos.Include(x => x.Vendedor)
                                         .Include(x => x.Cliente)
                                         .FirstOrDefault(x => x.Id == id);
            return pedido;
        }

        public Pedido ObterPorVendedorId(int vendedorId)
        {
            var pedido = _context.Pedidos.Find(vendedorId);
            return pedido;
        }

        public Pedido ObterPorClienteId(int clienteId)
        {
            var pedido = _context.Pedidos.Find(clienteId);
            return pedido;
        }

        public Pedido AtualizarPedido(Pedido pedido)
        {
            _context.Pedidos.Update(pedido);
            _context.SaveChanges();
            return pedido;
        }

        public void DeletarPedido(Pedido pedido)
        {
            _context.Pedidos.Remove(pedido);
            _context.SaveChanges();
        }
        public List<Pedido> Listar()
        {
            return _context.Pedidos.ToList();
        }
    }
}

