using System;
using System.Collections.Generic;
using System.Text;

namespace _01_Fiap.UI.HelloWorld.Model
{
    abstract class Pessoa
    {

        //Metodo abstract e normais
        public abstract void PagarImposto(decimal dinheiro);

        public virtual void Investir(decimal dinheiro)
        {
            Console.WriteLine("Investindo" + dinheiro);
        }

        //Construtor = ctor tab tab
        public Pessoa()
        {

        }

        public Pessoa(String nome)
        {
            Nome = nome;
            
        }

        //Atributo - Field/Campos
        private string _nome;

        //Métodos Gets/Sets - Propriedades
        public int Codigo { get; set; }

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
    }
}
