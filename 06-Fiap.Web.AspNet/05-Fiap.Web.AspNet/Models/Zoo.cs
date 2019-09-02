using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace _05_Fiap.Web.AspNet.Models
{

    [Table("TB_ZOO")]

    public class Zoo 
    {
       
        [Column("Id"), HiddenInput]
        public int ZooId { get; set; }

        [Column("Jaula")]
        public int Jaulas { get; set; }

        [Column("Data Abertura")]
        [DataType(DataType.Date),Display(Name="Data Abertura")]
        public DateTime DataAbertura { get; set; }

        [Required,MaxLength(50),Column("Nome")]
        public string Nome { get; set; }

        [Column("Entidade administradora")]
        [Display(Name ="Tipo")]
        public Tipo EntidadeAdministradora { get; set; }
    }
}
