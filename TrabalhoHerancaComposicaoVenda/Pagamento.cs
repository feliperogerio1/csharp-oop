using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoHerancaComposicaoVenda
{
    public abstract class Pagamento
    {
        protected DateTime data;
        protected double total;
        public Pagamento(double total)
        {
            this.data = DateTime.Now;
            this.total = total;
        }
        public abstract bool RealizarPagamento();
        public abstract void ExibirDados();
    }

}