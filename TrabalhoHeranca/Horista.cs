using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoHeranca
{
    public class Horista : Funcionario
    {
        protected int qtdeHorasSemana;
        public int QtdeHorasSemana
        {
            get { return qtdeHorasSemana; }
            set { qtdeHorasSemana = value; }
        }
        public Horista(int codigo, string nome, double salario, int qtdeHorasSemana) : base(codigo, nome, salario)
        {
            this.QtdeHorasSemana = qtdeHorasSemana;
        }
        public void Exibir()
        {
            base.Exibir();
            Console.WriteLine("Quantidade de horas por semana: " + this.qtdeHorasSemana);
        }
    }
}