using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoHerancaComposicaoVenda
{
    public class Produto
    {
        private long codigo;
        public long Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        
        private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        
        private double preco;
        public double Preco
        {
            get { return preco; }
            set { preco = value; }
        }
        
        private int estoque;
        public int Estoque
        {
            get { return estoque; }
            set { estoque = value; }
        }
        
        
        public Produto CadastrarProduto()
        {
            Console.WriteLine("Digite o código: ");
            this.codigo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o nome: ");
            this.nome = Console.ReadLine();
            Console.WriteLine("Digite o preco: ");
            this.preco = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o estoque: ");
            this.estoque = Convert.ToInt32(Console.ReadLine());
            return this;// representa o objeto com conteúdo após a digitação
        }
    }
}