using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Threading.Tasks;

namespace FuncionarioAbstrato
{
    public abstract class Funcionario
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }
        public List<Dependente> VetDependente { get; set; }
        public Funcionario(int c, string n, double s)
        {
            this.Codigo = c;
            this.Nome = n;
            this.Salario = s;
            VetDependente = new List<Dependente>();         
        }
        public virtual void ExibirDados()// método concreto - que tem lógica
        {
            Console.WriteLine("Código: " + Codigo + "\tNome: " + Nome + "\tSalário: " + Salario);
        }
        // só temos a assinatura do método
        // sabemos o que faz pelo nome, se precisa de valores e se retorna algo
        public abstract double CalcularSalario(int diasUteis);
        public void AdicionarDependente(Dependente novoDep)
        {
            VetDependente.Add(novoDep);
        }
        public void ListarDependente()
        {
            foreach(Dependente d in VetDependente)
            {
                d.ExibirDados();
            }
        }
        public void RemoverDependentesMaioridade(int codigo)
        {
            for(int i = 0; i < VetDependente.Count; i++)
            {
                Dependente d = VetDependente.ElementAt<Dependente>(i);
                bool resultadoIdade = d.VerificarMaiorIdade();
                if(d.Codigo == codigo && resultadoIdade)
                {
                    VetDependente.Remove(d);
                    break;
                }
            }
        }
        public int CalcularTotalDependente()
        {
            return VetDependente.Count;
        }
    }
}