using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace FuncionarioAbstrato
{
    public class Dependente
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public Dependente(int codigo, string nome, int idade) 
        {
            this.Codigo = codigo;
            this.Nome = nome;
            this.Idade = idade;
        }
        public bool VerificarMaiorIdade()
        {
            if(this.Idade >= 18)
            {
                return true;
            }
            return false;
        }
        public void ExibirDados()
        {
            Console.WriteLine("Nome: " + Nome + "\tIdade: " + Idade);
        }
    }
}