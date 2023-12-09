using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NavegacaoConta
{
    public class Conta
    {
        public int Numero { get; set; }
        public List<Cliente> VetorTitular { get; set; }
        public decimal Saldo { get; set; }
        public void AdicionarClientes(Cliente c)
        {
            VetorTitular.Add(c);   
        }
    }
}