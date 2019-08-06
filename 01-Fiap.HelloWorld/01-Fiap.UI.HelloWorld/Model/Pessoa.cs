using System;
using System.Collections.Generic;
using System.Text;

namespace _01_Fiap.UI.HelloWorld.Model
{
    class Pessoa
    {
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
