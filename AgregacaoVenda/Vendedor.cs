using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoVenda
{
    public class Vendedor
    {
        public double Comissao { get; set; }
        public void GerarComissao(Produto p) {
            double comissao = p.Preco * 0.02;
            Comissao = Comissao + comissao;
        }
        public void MostrarAtributos()
        {
            Console.WriteLine("Comissão: " + Comissao);
        }
    }
}