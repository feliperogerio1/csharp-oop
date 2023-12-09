using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace AgregacaoVenda
{
    public class Venda
    {
        public Comprador Comp { get; set; }
        public Vendedor Vend { get; set; }
        public List<Produto> VetProd { get; set; }
        public Venda()
        {
            this.Comp = new Comprador();
            this.Vend = new Vendedor();
            this.VetProd = new List<Produto>();
            AdicionarProdutos();
            RealizarOperacoes();
        }
        public void AdicionarProdutos()
        {
            VetProd.Add(new Produto());
        }
        public void RealizarOperacoes()
        {
            foreach(Produto p in VetProd)
            {
                Vend.GerarComissao(p);
                Comp.ExtrairVerba(p);
            }
        }
        public void MostrarAtributos()
        {
            Console.WriteLine("Detalhes da Venda:");
            Comp.MostrarAtributos();
            Vend.MostrarAtributos();
            Console.WriteLine("Produtos Vendidos:");
            foreach (Produto produto in VetProd)
            {
                produto.MostrarAtributos();
            }
        }
    }
}