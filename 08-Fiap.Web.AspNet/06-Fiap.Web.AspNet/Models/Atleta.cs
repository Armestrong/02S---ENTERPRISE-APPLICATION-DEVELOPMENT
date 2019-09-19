using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _06_Fiap.Web.AspNet.Models
{
    public class Atleta
{
        public int AtletaId { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public int Profissional { get; set; }

        public IList<CorridaAtleta> CorridaAtletas { get; set; }
    }
}
