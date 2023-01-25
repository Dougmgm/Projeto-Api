using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Projeto_API.Dto;

namespace Projeto_API.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int VendedorId { get; set; }
        public Vendedor Vendedor { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public float ValorTotal { get; set; }
       
        public Pedido()
        {

        }

        public Pedido(CadastrarPedidoDTO dto)
        {
            Date = dto.Date;
            VendedorId = dto.VendedorId;
            ClienteId = dto.ClienteId;
            ValorTotal = dto.ValorTotal;
        }

        public void MapearAtualizarPedidoDTO(AtualizarPedidoDTO dto)
        {
            Date = dto.Date;
            VendedorId = dto.VendedorId;
            ClienteId = dto.ClienteId;
            ValorTotal = dto.ValorTotal;
        }
        
    }
}