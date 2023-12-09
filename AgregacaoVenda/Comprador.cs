using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoVenda
{
    public class Comprador
    {
        public double Verba { get; set; }
        public Comprador()
        {
            Console.Write("Digite a verba: ");
            this.Verba = Convert.ToDouble(Console.ReadLine());
        }
        public void ExtrairVerba(Produto p)
        {
            double preco = p.Preco;
            Verba = Verba - preco;
        }
        public void MostrarAtributos()
        {
            Console.WriteLine("Verba: " + Verba);
        }
    }
}