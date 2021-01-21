using System;
using System.Collections.Generic;
using System.Text;

namespace Banco
{
    class Conta
    {   private TipoConta TipoConta { get; set; }
        private double Saldo {get ;set;}
        private double Credito { get; set; }
        private string Nome { get; set; }

        public Conta(TipoConta tipoconta, double saldo, double credito, string nome)
        {
             TipoConta = tipoconta;
             Saldo = saldo;
             Credito = credito;
             Nome = nome;
        }
        public bool Sacar(double ValorSaque)
        {
            if (ValorSaque < Credito)
            {
                Console.WriteLine("Saldo insuficiente");
                return false;
            }
            Saldo -= ValorSaque;
            Console.WriteLine("Saldo atual da conta de {0} e {1}",Nome, Saldo);
            return true;
          
        }
          public void Deposito(double valordeposito)
          {
            Saldo += valordeposito;
            Console.WriteLine("Saldo atual da conta de {0} e {1}", Nome, Saldo);
        }
        public void Transferir(double ValorTransf,Conta contaDestino)
        {
            if (Sacar(ValorTransf))
            {
                contaDestino.Deposito(ValorTransf);
            }
        }
        public override string ToString()
        {
            return " Tipoconta: " + TipoConta + " | "
                + " Nome: " + Nome + " | "
                + " Saldo: " + Saldo + " | "
                + " Credito: " + Credito;
                    
        }

    }
}
