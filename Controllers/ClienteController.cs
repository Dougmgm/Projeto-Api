using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Projeto_API.Dto;
using Projeto_API.Models;
using Projeto_API.Repository;

namespace Projeto_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {
        private readonly ClienteRepository _repository;
        public ClienteController(ClienteRepository repository){
            _repository = repository;
        }

        [HttpPost]
        public IActionResult Cadastrar(CadastrarClienteDTO dto)
        {
            var cliente = new Cliente(dto);
            _repository.Cadastrar(cliente);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult ObterPorId(int id)
        {
            var cliente = _repository.ObterPorId(id);
            if(cliente is not null){
                var clienteDTO = new ObterClienteDTO(cliente);
                return Ok(clienteDTO);
            } 
            else {
                return NotFound(new {Mensagem = "Cliente não encontrado" });
            }
        }

        [HttpGet("ObterPorNome/{nome}")]
        public IActionResult ObterPorNome(string nome)
        {
            var clientes = _repository.ObterPorNome(nome);
            return Ok(clientes);
        }

        [HttpGet("ObterPorLogin/{login}")]
        public IActionResult ObterPorLogin(string login)
        {
            var clientes = _repository.ObterPorLogin(login);
            return Ok(clientes);
        }

        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            var cliente = _repository.ObterPorId(id);

            if (cliente is not null)
            {
                _repository.DeletarCliente(cliente);
                return NoContent();
            }
            else
            {
                return NotFound(new {Mensagem = "Cliente não encontrado" });
            }
        }

        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, AtualizarClienteDTO dto)
        {
            var cliente = _repository.ObterPorId(id);

            if (cliente is not null)
            {
                cliente.MapearAtualizarClienteDTO(dto);
                _repository.AtualizarCliente(cliente);
                return Ok(cliente);
            }
            else 
            {
                return NotFound(new {Mensagem = "Cliente não encontrado" });
            }
        }

        [HttpPatch("{id}")]
        public IActionResult AtualizarSenha(int id, AtualizarSenhaClienteDTO dto)
        {
            var cliente = _repository.ObterPorId(id);
            if (cliente is not null)
            {
                _repository.AtualizarSenha(cliente, dto);
                return Ok();
            }
            else
            {
                return NotFound(new {Mensagem = "Cliente não encontrado" });
            }
            
            
        }

        /*[HttpGet("Listar")]
        public IActionResult Listar()
        {
            var clientes = _repository.Listar();
            return Ok(clientes);
        }*/
    }
}