using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace _05_Fiap.Web.AspNet.Models
{

    [Table("TB_ANIMAAL")] 
    public class Animal
    {
        [HiddenInput]
        public int AnimalId { get; set; }

        [MaxLength(50)]
        public string Nome { get; set; }

        public bool Carnivoro { get; set; }

        [Display(Name ="TipoAnimal")]
        public TipoAnimal Tipo { get; set; }
    }
}
