using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseFuncionario
{
    public class Funcionario
    {
        public int codigo;
        public string nome;
        public double salario;
        public void MostrarAtributos()
        {
            Console.WriteLine("Código: " + codigo + "\n Nome: " + nome + "\n Salário: " + salario);
        }
    }
}