using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Projeto_API.Models;

namespace Projeto_API.Dto
{
    public class ObterItemPedidoDTO
    {
        public int PedidoId { get; set; }
        public int Id { get; set; }
        public int ServicoId { get; set; }
        public int Quantidade { get; set; }
        public decimal Valor { get; set; }

        public ObterItemPedidoDTO(ItemPedido itemPedido) 
        {
            PedidoId = itemPedido.PedidoId;
            Id = itemPedido.Id;
            ServicoId = itemPedido.ServicoId;
            Quantidade = itemPedido.Quantidade;
            Valor = itemPedido.Valor;
        }
    }
}