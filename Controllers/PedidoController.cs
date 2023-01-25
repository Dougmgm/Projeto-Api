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
    public class PedidoController : ControllerBase
    {
        private readonly PedidoRepository _repository;
        public PedidoController(PedidoRepository repository){
            _repository = repository;
        }

        [HttpPost]
        public IActionResult Cadastrar(CadastrarPedidoDTO dto)
        {
            var pedido = new Pedido(dto);
            _repository.Cadastrar(pedido);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult ObterPorId(int id)
        {
            var pedido = _repository.ObterPorId(id);
            if(pedido is not null){
                return Ok(pedido);
            } 
            else 
            {
                return NotFound(new {Mensagem = "Pedido não encontrado" });
            }
        }


        [HttpGet("ObterPorVendedorId/{vendedorId}")]
        public IActionResult ObterPorVendedorId(int vendedorId)
        {
            var pedido = _repository.ObterPorVendedorId(vendedorId);
            if(pedido is not null){
                return Ok(pedido);
            } 
            else {
                return NotFound(new {Mensagem = "Vendedor não encontrado" });
            }
        }

        [HttpGet("ObterPorClienteId/{clienteId}")]
        public IActionResult ObterPorClienteId(int clienteId)
        {
            var pedido = _repository.ObterPorClienteId(clienteId);
            if(pedido is not null){
                return Ok(pedido);
            } 
            else {
                return NotFound(new {Mensagem = "Cliente não encontrado" });
            }
        }

        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, AtualizarPedidoDTO dto)
        {
            var pedido = _repository.ObterPorId(id);

            if (pedido is not null)
            {
                pedido.MapearAtualizarPedidoDTO(dto);
                _repository.AtualizarPedido(pedido);
                return Ok(pedido);
            }
            else 
            {
                return NotFound(new {Mensagem = "Pedido não encontrado" });
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            var pedido = _repository.ObterPorId(id);

            if (pedido is not null)
            {
                _repository.DeletarPedido(pedido);
                return NoContent();
            }
            else
            {
                return NotFound(new {Mensagem = "Pedido não encontrado" });
            }
        }
    }
}