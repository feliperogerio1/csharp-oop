using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceAutenticavel
{
    public class Gerente : Funcionario, IAutenticavel
    {
        public bool Autenticar(int senha)
        {
            if (this.Senha == senha)
            {
                Console.WriteLine("Você é um gerente!");
                return true;
            }
            return false;
        }
    }
}