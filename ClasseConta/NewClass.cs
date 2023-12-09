using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _22._08
{
    public class NewClass
    {
        //declaração dos atributos
        public int numero;
        public string titular;
        public double saldo;
        //declaração dos métodos
        public void Sacar(double valorSaque)
        {
            saldo = saldo - valorSaque;
            //saldo -= valorSaque;
        }
        public void Depositar(double valorDeposito)
        {
            saldo = saldo + valorDeposito;
        }
        public void MostrarAtributo()
        {
            Console.WriteLine("Número: " + numero + "\t Titular: " + titular + "\t Saldo: " 
+ saldo);
        }
        public void Transferir(double valor,NewClass objeto)
        {
            Sacar(valor);
            objeto.Depositar(valor);
        }
    }
}