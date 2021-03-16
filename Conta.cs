using System;
using System.Collections.Generic;
using System.Text;

namespace BancoDio
{
    class Conta
    {
        private string Nome { get; set; }
        private double Saldo { get; set; }
        private double Credito { get; set; }
        private Tipoconta TipoConta { get; set; }

        public Conta(string nome, double saldo, double credito, Tipoconta tipoConta)
        {
            Nome = nome;
            Saldo = saldo;
            Credito = credito;
            TipoConta = tipoConta;
        }
        public bool Sacar(double vSaque)
        {
            if(Saldo - vSaque < (Credito * -1))
            {
                Console.WriteLine("Saldo insuficiente!");
                return false;
            }
            else
            {
                Saldo -= vSaque;
                Console.WriteLine("Saldo atual de " + Nome + " é " + Saldo);
                return true;
            }
        }
        public void Depositar(double vDeposito)
        {
            Saldo += vDeposito;
            Console.WriteLine("Saldo atual de " + Nome + " é " + Saldo);
        }
        public void Transferir(double vTransf, Conta contaDest)
        {
            if (Sacar(vTransf))
            {
                contaDest.Depositar(vTransf);
            }
        }
        public override string ToString()
        {
            string retorno = "TipoConta " + TipoConta + " | NOME " + Nome + " | ";
            retorno += "Saldo " + Saldo + " | Credito " + Credito;
            return retorno;
        }
    }
}
