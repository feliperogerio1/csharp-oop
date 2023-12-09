using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace TrabalhoHerancaComposicaoVenda
{
    public class Venda
    {
        private DateTime data;
        private double total;
        private List<ItemVenda> vetItemVenda;
        private List<Pagamento> vetPagamentos;
        private Pagamento pag;
        public Pagamento Pag 
        {
            get { return pag; }
            set { pag = value; }
        }
        
        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }
        
        public double Total
        {
            get { return total; }
            set { total = value; }
        }
        public List<ItemVenda> VetItemVenda
        {
            get { return vetItemVenda; }
            set { vetItemVenda = value; }
        }
        public List<Pagamento> VetPagamentos
        {
            get { return vetPagamentos; }
            set { vetPagamentos = value; }
        }
        
        public Venda()
        {
            VetItemVenda = new List<ItemVenda>();
            VetPagamentos = new List<Pagamento>();
            this.Data = DateTime.Now;
        }
        public void AdicionarItemVenda(int cod, int qtde, ProdutoDAO dao) 
        {
            VetItemVenda.Add(new ItemVenda(cod, qtde, dao));
        }
        public double ObterTotal()
        {
            double totalVenda = 0.0;
            for (int i = 0; i < VetItemVenda.Count; i++) 
            {
                totalVenda += VetItemVenda.ElementAt<ItemVenda>(i).Subtotal;
            }
            if (VetItemVenda.Count >= 50) {
                totalVenda = totalVenda - (totalVenda * 0.1);
            }
            return totalVenda;
        }
        public void RegistrarPagamento(Pagamento p)
        {
            VetPagamentos.Add(p);
        }
        public void CriarPagamento(string tipo)
        {
            if (tipo == "1") 
            {
                Cartao cartao = new Cartao(this.Total);
                this.Pag = cartao.InserirCartao();
                if (cartao.RealizarPagamento())
                {
                    this.RegistrarPagamento(this.Pag);
                }
            }
            else if (tipo == "2")
            {
                Cheque cheque = new Cheque(this.Total);
                this.Pag = cheque.InserirCheque();
                if (cheque.RealizarPagamento())
                {
                    this.RegistrarPagamento(this.Pag);
                }
            }
            else if (tipo == "3")
            {
                Especie especie = new Especie(this.Total);
                this.Pag = especie.EntregarDinheiro();
                if (especie.RealizarPagamento())
                {
                    this.RegistrarPagamento(this.Pag);
                }
            }
        }
        public void ExibirDadosVetItens()
        {
            Console.WriteLine("Itens de venda:");
            foreach (ItemVenda item in VetItemVenda) 
            {
                if (item.Quantidade != 0) 
                {
                    Console.WriteLine("Quantidade: " + item.Quantidade + "\t Preço: R$" + item.Preco + "\t SubTotal: R$" + item.Subtotal);
                }
            }
        }
        public void ExibirDadosVenda()
        {
            Console.WriteLine("Total da venda: R$" + this.Total + "\t Data: " + this.Data);
        }
        public void ExibirDadosVetPagamento()
        {
            Console.WriteLine("Métodos de pagamento:");
            foreach (Pagamento pag in VetPagamentos) 
            {
                pag.ExibirDados();
            }
        }
    }
}
/*
1 - Façam os relacionamentos existirem na composição e com a classe pagamento
2 - Implemente os encapsulamentos
3 - Implemente o Exibir() de todas as classes
4 - Implementar os construtores com todos os parâmetros
5 - Instanciar objetos para testar
*/