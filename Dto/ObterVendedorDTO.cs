using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Projeto_API.Models;

namespace Projeto_API.Dto
{
    public class ObterVendedorDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }

        public ObterVendedorDTO(Vendedor vendedor)
        {
            Id = vendedor.Id;
            Name = vendedor.Name;
            Login = vendedor.Login;
            Senha = vendedor.Senha;
        }
    }
}