using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaCliente
{
    public class Juridico : Cliente
    {
        private int cnpj;
        public int Cnpj
        {
            get { return cnpj; }
            set { cnpj = value; }
        }
        public Juridico(int codigo, string nome, int cnpj) : base (codigo, nome)
        {
            this.Cnpj = cnpj;
        }
        public void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine("\tCnpj: " + this.Cnpj);
        }
    }
}