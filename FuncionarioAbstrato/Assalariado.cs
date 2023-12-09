using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FuncionarioAbstrato
{
    public class Assalariado : Funcionario
    {
        public override double CalcularSalario(int diasUteis)
        {
            return Salario / 30 * diasUteis;
        }
        public Assalariado(int c, string n, double s) : base (c, n, s)
        {
        }
    }
}