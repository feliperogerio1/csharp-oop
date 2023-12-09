using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoHerancaComposicaoVenda
{
    
    public class ProdutoDAO
    {
        private List<Produto> vetProdutos;
        public List<Produto> VetProdutos
        {
            get { return vetProdutos; }
            set { vetProdutos = value; }
        }
        public ProdutoDAO()
        {
            VetProdutos = new List<Produto>();
        }
        public void AdicionarProduto(Produto p)
        {
            VetProdutos.Add(p);
        }
        public Produto ObtemProduto(int cod) 
        {
            for (int i = 0; i < vetProdutos.Count; i++) 
            {
                Produto d = VetProdutos.ElementAt<Produto>(i);
                if (d.Codigo == cod) 
                {
                    return d;
                }
            }
            return null;
        }
        public void AtualizarEstoque(int cod, int qtde)
        {
            for (int i = 0; i < vetProdutos.Count; i++) 
            {
                Produto d = VetProdutos.ElementAt<Produto>(i);
                if (d.Codigo == cod) 
                {
                    d.Estoque = d.Estoque - qtde;
                }
            }
        }
        public void ExibirDados()
        {
            Console.WriteLine("\nProdutos cadastrados:");
            foreach (Produto p in VetProdutos) {
                Console.WriteLine("Código: " + p.Codigo + "\t Nome: " + p.Nome+ "\tPreço: R$" + p.Preco + "\tEstoque: " + p.Estoque);
            }
        }
    }
}