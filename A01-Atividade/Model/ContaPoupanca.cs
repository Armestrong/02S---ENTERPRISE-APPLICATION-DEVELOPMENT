using System;
using System.Collections.Generic;
using System.Text;
using A01.xception;
using A1.Model;

namespace Fiap.Banco.Model
{
    class ContaPoupanca : Conta, IContaInvestimento
    {
        private readonly decimal _rendimento;
        public decimal Taxa { get; set; }

        public ContaPoupanca(decimal valor)
        {
            _rendimento = valor;
        }

        public decimal CalcularRetornoInsvestimento()
        {
            return Saldo* Taxa;
        }

        public override void Depositar(decimal valor)
        {
            Saldo += valor;
        }

        public override void Retirar(decimal valor)
        {
            if (Saldo < valor)
            {
                throw new SaldoInvalido("Valor Insuficinte");

            }
            else
            {
                Saldo -= valor + Taxa;
            }
        }
    }
}
