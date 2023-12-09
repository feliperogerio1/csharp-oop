using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoHerancaComposicaoVenda
{
    public class Cartao : Pagamento
    {
        private string dadosTransacao;
        private int resultadoTransacao;
        public string DadosTransacao
        {
            get { return dadosTransacao; }
            set { dadosTransacao = value; }
        }
        
        public int ResultadoTransacao
        {
            get { return resultadoTransacao; }
            set { resultadoTransacao = value; }
        }
        public Cartao(double total) : base (total)
        {
        }
        public Pagamento InserirCartao()
        {
            Console.Write("Insira os dados de transação: ");
            this.DadosTransacao = Console.ReadLine();
            Console.WriteLine();
            return this;
        }
        public override bool RealizarPagamento()
        {
            Random random = new Random();
            this.ResultadoTransacao = random.Next(1, 3);
            if (this.ResultadoTransacao == 1)
            {
                Console.WriteLine("Pagamento realizado com cartão!");
                return true;
            }
            Console.WriteLine("Não foi possível realizar pagamento com cartão!");
            return false;
        }
        public override void ExibirDados()
        {
            Console.WriteLine($"Cartão - Data: {data}, Dados Transação: {dadosTransacao}, Resultado Transação: {resultadoTransacao}");
        }
        
    }
}