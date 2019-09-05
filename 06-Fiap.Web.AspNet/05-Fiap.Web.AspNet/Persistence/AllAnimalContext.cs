using _05_Fiap.Web.AspNet.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _05_Fiap.Web.AspNet.Persistence
{
    public class AllAnimalContext :DbContext
    {
        public DbSet<Animal> Animais { get; set; }
        //construtor - ctor tab tab
        public AllAnimalContext(DbContextOptions options)
        : base(options) { }
    }
}
