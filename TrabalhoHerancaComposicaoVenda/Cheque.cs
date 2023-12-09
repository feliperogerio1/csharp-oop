using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoHerancaComposicaoVenda
{
    public class Cheque : Pagamento
    {
        private long numero;
        private DateTime dataDeposito;
        private int situacao;
        public long Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        
        public DateTime DataDeposito
        {
            get { return dataDeposito; }
            set { dataDeposito = value; }
        }
        
        public int Situacao
        {
            get { return situacao; }
            set { situacao = value; }
        }
        public Cheque(double total) : base (total)
        {
        }
        public Pagamento InserirCheque()
        {
            Console.Write("Insira o número do cheque: ");
            this.Numero = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Insira a situação (1 - Compensado, 2 - Devolvido): ");
            this.Situacao = Convert.ToInt32(Console.ReadLine());
            this.DataDeposito = DateTime.Now;
            return this;
        }
        public override bool RealizarPagamento()
        {
            if (this.Situacao == 1)
            {
                Console.WriteLine("Pagamento realizado com cheque!");
                return true;
            }
            else if (this.Situacao == 2) 
            {
                Console.WriteLine("Não foi possível realizar pagamento com cheque!");
                return false;
            }
            else 
            {
                Console.WriteLine("Opção inválida!");
                return false;
            }
        }
        public override void ExibirDados()
        {
            Console.WriteLine($"Cheque - Data: {data}, Número: {numero}, Data Depósito: {dataDeposito}, Situação: {situacao}");
        }
        
    }
}