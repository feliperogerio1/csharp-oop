using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FuncionarioAbstrato
{
    public class Departamento
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public List<Funcionario> VetFuncionario { get; set; }
        public Departamento(int codigo, string nome)
        {
            this.Codigo = codigo;
            this.Nome = nome;
            VetFuncionario = new List<Funcionario>();
        }
        //O parametro f servirá para atender a uma instancia de objeto assalariado ou comissionado
        public void Admitir(Funcionario f)
        {
            VetFuncionario.Add(f);
        }
        public void ListarFuncionario()
        {
            Console.WriteLine("\n\nLista de funcionários do departamento " + Nome);
            foreach(Funcionario f in VetFuncionario)
            {
                f.ExibirDados();
            }
        }
        public void Demitir(int cod)
        {
            for(int i = 0; i < VetFuncionario.Count; i++) 
            {
                Funcionario f = VetFuncionario.ElementAt<Funcionario>(i);
                if(f.Codigo == cod) 
                {
                    VetFuncionario.Remove(f);
                    break;
                }
            }
        }
        public double CalcularFolha(int diasUteis)
        {
            double folha = 0;
            for(int i = 0; i < VetFuncionario.Count; i++)
            {
                Funcionario f = VetFuncionario.ElementAt<Funcionario>(i);
                folha = folha + f.CalcularSalario(diasUteis);
            }
            return folha;
        }
        public void MostrarQtdeDependentesFuncionario()
        {
            for(int i = 0; i < VetFuncionario.Count; i++)
            {
                Funcionario f = VetFuncionario.ElementAt<Funcionario>(i);
                Console.WriteLine("Funcionário " + f.Nome + " possui " + f.CalcularTotalDependente() +
                 " dependentes.");
            }
        }
    }
}