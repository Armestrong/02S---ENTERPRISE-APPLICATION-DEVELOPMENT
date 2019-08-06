using System;
using _01_Fiap.UI.HelloWorld.Model;

namespace _01_Fiap.UI.HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciar uma pessoa fisica
            PessoaFisica pf = new PessoaFisica();
            //Setar um valor para o nome
            pf.Nome = "Thiago";
            //Exibir o nome da pessoa
            Console.WriteLine(pf.Nome);
        }
    }
}
