using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaFuncionario
{
    public class Gerente : Funcionario
    {
        // apliquei o polimorfismo usando o override
        public override double CalcularBonificacao()
        {
            return Salario * 15 / 100;
        }
        public Gerente(int codigo, string nome, double salario) : base(codigo, nome, salario)
        {
        }
    }
}