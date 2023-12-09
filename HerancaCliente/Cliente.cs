using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaCliente
{// protected permite que a subclasse veja os atributos da superclasse
    public class Cliente //clase base-superclasse
    {
        protected int codigo;
        protected string nome;
        public void Mostrar()
        {
            Console.Write("Código: " + this.codigo + "\tNome: " + this.nome);
        }
        public Cliente(int codigo, string nome)
        {
            this.Codigo = codigo;
            this.Nome = nome;
        }
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
    }
}