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
            pf.Nome = "Armestrong";
            pf.Sexo = Genero.Masculino;
            //Exibir o nome da pessoa
            Console.WriteLine(pf.Nome);

            // Instanciar uma pessoaFisica 2
            PessoaFisica pessoa = new PessoaFisica()
            {
                Nome = "Altolfo",
                Cpf = "123332",
                
            };



        }
    }
}
