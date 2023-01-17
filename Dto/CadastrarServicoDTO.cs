using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_API.Dto
{
    public class CadastrarServicoDTO
    {
        private object x;

        public CadastrarServicoDTO(object x)
        {
            this.x = x;
        }

        public string Nome { get; set; }
        public string Descricao { get; set; }
    }
}