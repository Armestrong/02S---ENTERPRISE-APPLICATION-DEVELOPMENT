using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _06_Fiap.Web.AspNet.Models
{
    public class Corrida
    {
        [HiddenInput]
        public int CorridaId { get; set; }
        public string Nome { get; set; }
        public float Distancia { get; set; }
        public bool Premiacao { get; set; }
        public Categoria Categoria { get; set; }

        // Relacionamento Tajeto
        public Trajeto Trajeto { get; set; }
        public int TrajetoId { get; set; }

        // Relacionamento Medalha
        public IList<Medalha> Medalhas { get; set; }

        // Relacionamento XCorridaAtleta
        public IList<CorridaAtleta> CorridaAtletas  { get; set; }

    }
}
