using Fiap.Banco.Model;
using System;

namespace A1
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente c = new ContaCorrente()
            {
                Agencia = 1,
                DataAbertura = DateTime.Now,
                Numero = 2,
                Saldo = 700,
                Tipo = Model.TipoConta.Comum
            };

            ContaPoupanca cp = new ContaPoupanca(0.06m) // "m" força ser decimal 
            {
                Agencia = 1,
                DataAbertura = new DateTime(2019, 1, 1),
                Numero = 2,
                Saldo = 700,
                Taxa = 10
            };

            try
            {
                c.Retirar(5000);
                Console.WriteLine(c.Saldo);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message); // fecha o prompt com uma tecla qualquer
            }

        }
    }
}
