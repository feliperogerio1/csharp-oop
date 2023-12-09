using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaCliente
{//     classe derivada : classe base
    public class Fisico : Cliente
    {
        private int rg;
        public Fisico(int codigo, string nome, int rg) : base (codigo, nome)
        {
            this.Rg = rg;
        }
        public int Rg
        {
            get { return rg; }
            set { rg = value; }
        }
        public void Mostrar()
        {
            base.Mostrar();//chama o método da superclasse
            Console.WriteLine("\tRg: " + this.Rg);
        }    
    }
}