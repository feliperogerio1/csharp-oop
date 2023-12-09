using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncapsulamentoFuncionario
{
    public class Funcionario
    {
        //declarar atributos 
        //matricula int
        //nome string
        //salario double
        //Não deixar atribuir valores 0 ou negativos para matricula e salario
        //retornar nome em letras maiusculas
        private int matricula;
        public int Matricula
        {
            get { return matricula; }
            set 
            {
                if (value > 0) 
                    matricula = value; 
                else
                    Console.WriteLine("Digite um valor válido!");
                }
        }
        private string nome;
        public string Nome
        {
            get { return nome.ToUpper(); }
            set { nome = value; }
        }
        private double salario;
        public double Salario
        {
            get { return salario; }
            set 
            { 
                if (value > 0)
                    salario = value; 
                else
                    Console.WriteLine("Digite um valor válido!");
            }
        }
        public double NovaPorcentagem(double porcentagem) 
        {
            salario = salario + (salario * (porcentagem / 100));
            return salario;
        }
        public void MostrarAtributos() {
            Console.WriteLine("Matrícula: " + matricula);
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Salário: " + salario);
        }
        

        //Criar um método para aumentar o salário a partir de uma porcentagem informada no
        //método Main()
        //Criar o método para Mostrar os atributos 
    }
}