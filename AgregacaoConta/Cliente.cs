using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoConta
{
    public class Cliente
    {
        public string Nome { get; set; }
        public int Rg { get; set; }
        public Cliente(string nome, int rg)
        {
            this.Nome = nome;
            this.Rg = rg;
        }
    }
}