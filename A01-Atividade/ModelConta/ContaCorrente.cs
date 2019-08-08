using System;
using System.Collections.Generic;
using System.Text;

namespace Fiap.Banco.Conta
{
    class ContaCorrente : Conta
    {
        public override void Depositar(decimal valor)
        {
            Console.WriteLine(Saldo = valor);
        }

        public override void Retirar(decimal valor)
        {
            if (TipoConta.Comum)
            {

            }
        }

        public TipoConta tConta { get; set; }


    }
}
