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
    public class ItemPedidoController : ControllerBase
    {
        private readonly ItemPedidoRepository _repository;
        public ItemPedidoController(ItemPedidoRepository repository){
            _repository = repository;
        }

        [HttpPost]
        public IActionResult Cadastrar(CadastrarItemPedidoDTO dto)
        {
            var itemPedido = new ItemPedido(dto);
            _repository.Cadastrar(itemPedido);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult ObterPorId(int id)
        {
            var itemPedido = _repository.ObterPorId(id);
            if(itemPedido is not null){
                return Ok(itemPedido);
            } 
            else {
                return NotFound(new {Mensagem = "Item do pedido não encontrado" });
            }
        }
    }
}