using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoHerancaComposicaoVenda
{
    public class VenderCaixa
    {
        private Venda venda;
        private ProdutoDAO dao;
        public ProdutoDAO Dao
        {
            get { return dao; }
            set { dao = value; }
        }
        
        public Venda Venda
        {
            get { return venda; }
            set { venda = value; }
        }
        
        public Venda IniciarVenda() 
        {
            return venda = new Venda();
        }
        public ProdutoDAO IniciarProdutoDAO()
        {
            return dao = new ProdutoDAO();
        }
        public void LancarItem(int cod, int qtde) 
        {
            venda.AdicionarItemVenda(cod, qtde, dao);
        }

        public void FinalizarVenda() 
        {
           venda.Total = venda.ObterTotal();
        }
        public void Pagar(string tipo)
        {
            venda.CriarPagamento(tipo);
        }
    }
}