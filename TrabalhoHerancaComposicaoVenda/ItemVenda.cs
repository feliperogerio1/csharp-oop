using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoHerancaComposicaoVenda
{
    public class ItemVenda
    {
        private int quantidade;
        private double preco;
        private double subtotal;
        private Produto objProduto;
        
        public int Quantidade
        {
            get { return quantidade; }
            set { quantidade = value; }
        }
        
        public double Preco
        {
            get { return preco; }
            set { preco = value; }
        }
        
        public double Subtotal
        {
            get { return subtotal; }
            set { subtotal = value; }
        }
        
        //ObjProduto é a associação estabelecida
        public Produto ObjProduto
        {
            get { return objProduto; }
            set { objProduto = value; }
        }
        
        public ItemVenda(int cod, int qtde, ProdutoDAO dao)
        {
            int quantidadeCompra = qtde;
            ObjProduto = dao.ObtemProduto(cod);
            if (ObjProduto != null) {
                if (ObjProduto.Estoque >= quantidadeCompra)
                {
                    this.Quantidade = quantidadeCompra;
                    this.Preco = ObjProduto.Preco;
                    this.Subtotal = this.Preco * this.Quantidade;
                    dao.AtualizarEstoque(cod, qtde);
                } 
                else 
                {
                    Console.WriteLine("Quantidade é maior que a disponibilidade no estoque!");
                }  
            }
            else 
            {
                Console.WriteLine("Produto não encontrado!");
            } 
        }
    }
}