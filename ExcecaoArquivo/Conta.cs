using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExcecaoArquivo
{
    public class Conta
    {
        public double Saldo { get; private set; }
        public void Depositar(double valorDeposito)
        {
            if (valorDeposito > 0)
                Saldo += valorDeposito;
            else
                throw new ArgumentException();
        }
    }
}