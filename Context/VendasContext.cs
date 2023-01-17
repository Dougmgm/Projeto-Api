using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Projeto_API.Models;

namespace Projeto_API.Context
{
    public class VendasContext : DbContext
    {
        public VendasContext(DbContextOptions<VendasContext> options) :     base(options)
        {

        }

        public  DbSet<Cliente> Clientes { get; set; }
        public  DbSet<ItemPedido> ItemPedidos { get; set; }

        public  DbSet<Pedido> Pedidos { get; set; }

        public  DbSet<Servico> Servicos { get; set; }
        public  DbSet<Vendedor> Vendedores { get; set; }



    }
}