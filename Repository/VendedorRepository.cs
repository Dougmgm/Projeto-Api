using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Projeto_API.Context;
using Projeto_API.Dto;
using Projeto_API.Models;

namespace Projeto_API.Repository
{
    public class VendedorRepository
    {
        private readonly VendasContext _context;
        public VendedorRepository(VendasContext context)
        {
            _context = context;
        }

        public void Cadastrar(Vendedor vendedor)
        {
            _context.Vendedores.Add(vendedor);
            _context.SaveChanges();
        }

        public Vendedor ObterPorId(int id)
        {
            var vendedor = _context.Vendedores.Find(id);
            return vendedor;
        }

        public List<ObterVendedorDTO> ObterPorNome(string nome)
        {
            var vendedor = _context.Vendedores.Where(x => x.Name.Contains(nome))
                                              .Select(x => new ObterVendedorDTO (x))
                                              .ToList();
            return vendedor;
        }

        public List<ObterVendedorDTO> ObterPorLogin(string login)
        {
            var vendedor = _context.Vendedores.Where(x => x.Login.Contains(login))
                                              .Select(x => new ObterVendedorDTO (x))
                                              .ToList();
            return vendedor;
        }
    }
}