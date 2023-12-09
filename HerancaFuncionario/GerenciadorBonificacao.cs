using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaFuncionario
{
    public class GerenciadorBonificacao
    {
        private double totalBonificacao;
        public double TotalBonificacao
        {
            get { return totalBonificacao; }
            set { totalBonificacao = value; }
        }
        public void TotalizadorBonificacao(Funcionario f)
        {
            this.TotalBonificacao += f.CalcularBonificacao();
        }
        public void TotalizadorBonificacao(Secretario r)
        {
            this.TotalBonificacao += r.CalcularBonificacao();
        }
        public void TotalizadorBonificacao(Gerente g)
        {
            this.TotalBonificacao += g.CalcularBonificacao();
        }
        public void TotalizadorBonificacao(Diretor d)
        {
            this.TotalBonificacao += d.CalcularBonificacao();
        }
        public void Exibir()
        {
            Console.WriteLine("Total de bonificação: R$" + this.totalBonificacao);
        }
    }
}