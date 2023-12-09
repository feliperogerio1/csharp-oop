using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceAutenticavel
{
    public class Diretor : Funcionario, IAutenticavel
    {
        public bool Autenticar(int senha)
        {
            if (this.Senha == senha)
            {
                Console.WriteLine("Você é um diretor!");
                return true;
            }
            return false;
        }
    }
}