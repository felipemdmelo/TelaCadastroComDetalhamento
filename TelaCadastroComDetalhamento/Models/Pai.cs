using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TelaCadastroComDetalhamento.Models
{
    public class Pai
    {
        public string Nome { get; set; }

        public List<Filho> Filhos { get; set; }
    }
}
