using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
// propriedade é o nome do atributo encapsulado
namespace ConstrutorConta
{
    public class Conta
    {
        public int Numero { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }  
        public static int QtdeInstancias { get; set; }
        public void MostrarAtributos()
        {
            Console.WriteLine("Número: " + Numero + "\t Titular: " + Titular + "\t Saldo: " 
+ Saldo);
        }
        public Conta()
        {
            QtdeInstancias++;//incremento
        }
        public Conta(int numero)
        {
            this.Numero = numero;
            QtdeInstancias++;//incremento
        }   
        public Conta(int numero, double saldo)
        {
            this.Numero = numero;
            this.Saldo = saldo;
            QtdeInstancias++;//incremento
        }
        public Conta(int numero, string nome, double saldo)
        {
            this.Numero = numero;
            this.Titular = nome;
            this.Saldo = saldo;
            QtdeInstancias++;//incremento
        }
    }
}