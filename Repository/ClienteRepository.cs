using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Projeto_API.Context;
using Projeto_API.Dto;
using Projeto_API.Models;

namespace Projeto_API.Repository
{
    public class ClienteRepository
    {
         private readonly VendasContext _context;
        public ClienteRepository(VendasContext context)
        {
            _context = context;
        }

         public void Cadastrar(Cliente cliente)
        {
            _context.Clientes.Add(cliente);
            _context.SaveChanges();
        }

        public Cliente ObterPorId(int id)
        {
            var cliente = _context.Clientes.Find(id);
            return cliente;
        }

        public List<ObterClienteDTO> ObterPorNome(string nome)
        {
            var vendedor = _context.Clientes.Where(x => x.Nome.Contains(nome))
                                              .Select(x => new ObterClienteDTO (x))
                                              .ToList();
            return vendedor;
        }

        public List<ObterClienteDTO> ObterPorLogin(string login)
        {
            var vendedor = _context.Clientes.Where(x => x.Login.Contains(login))
                                              .Select(x => new ObterClienteDTO (x))
                                              .ToList();
            return vendedor;
        }

    }
}