using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoHeranca
{
    public class Mensalista : Funcionario
    {
        protected int qtdeHorasTrabalhadas;
        public int QtdeHorasTrabalhadas
        {
            get { return qtdeHorasTrabalhadas; }
            set { qtdeHorasTrabalhadas = value; }
        }
        public Mensalista(int codigo, string nome, double salario, int qtdeHorasTrabalhadas) : base(codigo, 
        nome, salario)
        {
            this.QtdeHorasTrabalhadas = qtdeHorasTrabalhadas;
        }
        public void Exibir()
        {
            base.Exibir();
            Console.WriteLine("Quantidade de horas trabalhadas: " + this.qtdeHorasTrabalhadas);
        }
    }
}