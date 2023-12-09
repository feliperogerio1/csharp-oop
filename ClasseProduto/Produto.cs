using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseProduto
{
    public class Produto
    {
        public int codigo;
        public string descricao;
        public double preco;
        
        public void MostrarAtributos()
        {
            Console.WriteLine("Código: " + codigo + "\n Descrição: " + descricao + 
            "\n Preço: " + preco);
        }
        public void MostrarValorTotal(double valorTotal)
        {
            System.Console.WriteLine("Valor total: " + valorTotal);
        }
    }
}