using DocumentFormat.OpenXml.Drawing;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace _07_Fiap.Web.AspNet.Models
{

    [Table("TB_CORRIDA")]
    public  class Corrida
    {
        [Column("Id"),HiddenInput]
        public int CorridaId { get; set; }
        public String Nome { get; set; }
        public float Distancia { get; set; }
        public bool Premiacao { get; set; }
        public Categoria Categoria { get; set; }
    }
}