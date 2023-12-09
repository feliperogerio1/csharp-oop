using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Threading.Tasks;

namespace AgregacaoVenda
{
    public class Produto
    {
        private int codigo; 
        private string nome; 
        public string Nome
        {
            get 
                { return nome; }
            set 
            {
                nome = value;
            }
        }
        private double preco;
        public double Preco
        {
            get
                {return preco;}
            set
            {   
                if (value >= 0)
                    preco = value;
                else
                    Console.WriteLine("Preço inválido!");
            }
        }
        private static int Cod = 500;
        public Produto()
        {
            Console.Write("Digite o nome do produto: ");
            this.Nome = Console.ReadLine();
            Console.Write("Digite o preço do produto: ");
            this.Preco = Convert.ToDouble(Console.ReadLine());
            AtribuirCodigo();
        }
        private void AtribuirCodigo()
        {
            this.codigo = Cod;
            Cod++;
        }
        public void MostrarAtributos()
        {
            Console.WriteLine("Código: " + codigo + "\tPreço: " + Preco + "\tNome: " + Nome);
        }
    }
}