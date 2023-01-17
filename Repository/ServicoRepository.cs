using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Projeto_API.Context;
using Projeto_API.Dto;
using Projeto_API.Models;

namespace Projeto_API.Repository
{
    public class ServicoRepository
    {
        private readonly VendasContext _context;
        public ServicoRepository(VendasContext context)
        {
            _context = context;
        }

        public void Cadastrar(Servico servico)
        {
            _context.Servicos.Add(servico);
            _context.SaveChanges();
        }

        public Servico ObterPorId(int id)
        {
            var servico = _context.Servicos.Find(id);
            return servico;
        }

        public List<CadastrarServicoDTO> ObterPorNome(string nome)
        {
            var servico = _context.Servicos.Where(x => x.Nome.Contains(nome))
                                              .Select(x => new CadastrarServicoDTO (x))
                                              .ToList();
            return servico;
        }

        public List<CadastrarServicoDTO> ObterPorDescricao(string descricao)
        {
            var servico = _context.Servicos.Where(x => x.Descricao.Contains(descricao))
                                              .Select(x => new CadastrarServicoDTO (x))
                                              .ToList();
            return servico;
        }
    }
}