using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_API.Dto
{
    public class AtualizarPedidoDTO
    {
        public DateTime Date { get; set; }
        public int VendedorId { get; set; }
        public int ClienteId { get; set; }
        public float ValorTotal { get; set; }
    }
}