using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Projeto_API.Dto;

namespace Projeto_API.Models
{
    public class Vendedor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }

        public Vendedor()
        {

        }

        public Vendedor(CadastrarVendedorDTO dto)
        {
            Name = dto.Name;
            Login = dto.Login;
            Senha = dto.Senha;
        }
    }
}