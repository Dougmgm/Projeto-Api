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

       public List<ObterServicoDTO> ObterPorNome(string nome)
        {
            var servico = _context.Servicos.Where(x => x.Nome.Contains(nome))
                                            .Select(x => new ObterServicoDTO (x))
                                            .ToList();
            return servico;
        }

       
       public List<ObterServicoDTO> ObterPorDescricao(string descricao)
        {
            var servico = _context.Servicos.Where(x => x.Descricao.Contains(descricao))
                                            .Select(x => new ObterServicoDTO (x))
                                            .ToList();
            return servico;
        }

        public Servico AtualizarServico(Servico servico)
        {
            _context.Servicos.Update(servico);
            _context.SaveChanges();
            return servico;
        }

        public void DeletarServico(Servico servico)
        {
            _context.Servicos.Remove(servico);
            _context.SaveChanges();
        }
        
        public List<Servico> Listar()
        {
            return _context.Servicos.ToList();
        }
    }
}
