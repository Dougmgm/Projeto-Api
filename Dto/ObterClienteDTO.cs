using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Projeto_API.Models;

namespace Projeto_API.Dto
{
    public class ObterClienteDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Login { get; set; }

        public ObterClienteDTO(Cliente cliente)
        {
            Id = cliente.Id;
            Nome = cliente.Nome;
            Login = cliente.Login;
        }
    }
}