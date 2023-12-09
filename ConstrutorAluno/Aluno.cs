using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstrutorAluno
{
    public class Aluno
    { 
        public long Ra { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public static long TemplateRa { get; set; }
        static Aluno()
        {
            TemplateRa = 1570482211000;
        }
        public void AtribuirRa() 
        {   
            TemplateRa++;
            Ra = TemplateRa;
        }
        public void MostrarAtributos()
        {
            Console.WriteLine("Ra: " + Ra + "\t Nome: " + Nome + "\t Idade: " + Idade);
        }
    } 
}