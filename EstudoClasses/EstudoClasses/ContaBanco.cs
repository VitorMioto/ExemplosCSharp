using System;
using System.Collections.Generic;
using System.Text;

namespace EstudoClasses
{
    class ContaBanco
    {
        public int Conta { get; private set; }
        public string NomeTitular { get; set; }
        public double Saldo { get; private set; }

        ContaBanco(int conta, string nome, double saldo = 0.0)
        {
            Conta = conta;
            NomeTitular = nome;
            Saldo = saldo;
        }

        public void Saque(double valor)
        {
            Saldo -= (valor + 5.00);
        }
        public void Deposito(double valor)
        {
            Saldo += valor;
        }

        public override string ToString()
        {
            return String.Format("Conta: {0} - Titular: {1} Saldo: R$ {2}", Conta, NomeTitular, Saldo);
        }
    }
}
