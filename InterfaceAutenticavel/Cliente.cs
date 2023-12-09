using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceAutenticavel
{
    public class Cliente : IAutenticavel
    {
        public int Senha { get; set; }
        public bool Autenticar(int senha)
        {
            if (this.Senha == senha)
            {
                Console.WriteLine("Você é um cliente");
                return true;
            }
            return false;
        }
    }
}