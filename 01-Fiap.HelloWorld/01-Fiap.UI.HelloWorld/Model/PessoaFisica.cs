using System;
using System.Collections.Generic;
using System.Text;

namespace _01_Fiap.UI.HelloWorld.Model
{

    class PessoaFisica : Pessoa, ITrabalhador
    {
        //Metodos
        public override void PagarImposto(decimal dinheiro)
        {
            Console.WriteLine("IMPOSTO" + dinheiro * 0.27m);
        }

        //Sobrescrever o comportamento do metodo pai
        public override void Investir(decimal dinheiro)
        {
            Console.WriteLine("PF investindo");
        }

        public void Trabalhar()
        {
            Console.WriteLine("Trabalhando");
        }


        //Construtor
        public PessoaFisica()
        {

        }

        public PessoaFisica(string nome) : base(nome)
        {

        }

        //Propriedades - Gets/Sets
        public Genero Sexo  { get; set; }
        public string Cpf { get; set; }
        public int Idade { get; set; }
        public DateTime DataNascimento { get; set; }

  
    }
}
