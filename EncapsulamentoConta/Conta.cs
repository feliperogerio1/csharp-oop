using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncapsulamentoConta
{
    public class Conta
    {
        //atributos encapsulamento
        /*
        private int numero;
        private string titular;//declaração do atributo
        private double saldo;
        */
        public int Numero { get; set; }//Propriedade-get/set
        public string Titular { get; set; }
        public double Saldo { get; set; }
        /*
        public int Numero
        {
            set
            {
                if (value > 0)
                    this.numero = value;
                else
                    Console.WriteLine("Número de conta inválido");
            }
            get 
            {
                return this.numero;
            }
        }
        
        public string Titular//declaração da propriedade
        {
            get { return titular.ToUpper(); }
            set { titular = value; }
        }
        
        public double Saldo//declaração dos métodos get e get
        {
            get { return saldo; }
            set { saldo = value; }
        }
        */
        
/* Forma de encapsulamento detalhada e semelhante a criação de funções 
        public void SetNumero(int numeroNovo)
        {
            numero = numeroNovo;
        }
        public int GetNumero()
        {
            return numero;
        }*/
    }
}