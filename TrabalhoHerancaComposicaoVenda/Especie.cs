using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoHerancaComposicaoVenda
{
    public class Especie : Pagamento
    {
        private double quantia;
        private double troco;
        public double Quantia
        {
            get { return quantia; }
            set { quantia = value; }
        }
        
        public double Troco
        {
            get { return troco; }
            set { troco = value; }
        }
        public Especie(double total) : base (total)
        {
        }
        public Pagamento EntregarDinheiro()
        {
            Console.Write("Insira a quantia: ");
            this.Quantia = Convert.ToDouble(Console.ReadLine());
            return this;
        }
        public bool CalcularTroco()
        {
            if (this.Quantia >= this.total)
            {
                this.Troco = this.Quantia - this.total;
                return true;
            }
            else 
            {
                Console.WriteLine("Quantia insuficiente para pagar!");
                return false;
            }
        }
        public override bool RealizarPagamento()
        {
            if (this.CalcularTroco())
            {
                Console.WriteLine("Pagamento realizado com espécie!");
                return true;
            }
                Console.WriteLine("Não foi possível realizar pagamento com espécie!");
                return false;
        }
        public override void ExibirDados()
        {
            Console.WriteLine("Espécie - Data: " + data + "\tQuantia: R$" + quantia + "\tTroco: R$" + troco);
        }
    }
}