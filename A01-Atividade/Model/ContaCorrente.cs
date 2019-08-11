using System;
using System.Collections.Generic;
using System.Text;
using A1.Model;

namespace Fiap.Banco.Model
{
    sealed class ContaCorrente : Conta
    {
        public TipoConta Tipo { get; set; }



        public override void Depositar(decimal valor)
        {
            Saldo += valor;
        }

        public override void Retirar(decimal valor)
        {
            if (Tipo == TipoConta.Comum && Saldo<valor)
            {
                throw new Exception("Saldo insuficiente");
            }
            else
            {
                Saldo -= valor;
            }  
        }

    }
}
