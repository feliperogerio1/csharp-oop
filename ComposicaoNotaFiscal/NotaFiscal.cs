using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoNotaFiscal
{
    public class NotaFiscal
    {
        public int Numero { get; set; }
        public string Data { get; set; }
        public List<ItemNotaFiscal> VetorItens { get; set; }
        public NotaFiscal(int numero, string data)
        {
            this.Numero = numero;
            this.Data = data;
            this.VetorItens = new List<ItemNotaFiscal>();
        }
        public void AdicionarItens(int qtde)
        {
            VetorItens.Add(new ItemNotaFiscal(qtde));
        }
        ~NotaFiscal()
        {
            //VetorItens = null;
            Console.WriteLine("Destruindo a nota fiscal");
        }
    }
}