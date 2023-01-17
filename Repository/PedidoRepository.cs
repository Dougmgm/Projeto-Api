using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        public void Cadastrar(Pedido pedido)
        {
            _context.Pedidos.Add(pedido);
            _context.SaveChanges();
        }

        public Pedido ObterPorId(int id)
        {
            var pedido = _context.Pedidos.Find(id);
            return pedido;
        }

        /* CUIDAR DISSO MAIS TARDE PELO 26:36
        public List<CadastrarPedidoDTO> ObterPorVendedorId(int vendedorId)
        {
            var pedidos = _context.Pedidos.Where(x => x.VendedorId.Contains(vendedorId))
                                              .Select(x => new CadastrarPedidoDTO (x))
                                              .ToList();
            return pedidos;
        }

        public List<ObterVendedorDTO> ObterPorClienteId(int clienteId)
        {
            var pedidos = _context.Pedidos.Where(x => x.ClienteId.Contains(clienteId))
                                              .Select(x => new CadastrarPedidoDTO (x))
                                              .ToList();
            return pedidos;
        }
        */ 
    }
}