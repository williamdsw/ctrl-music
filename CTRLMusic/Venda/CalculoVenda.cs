using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTRLMusic
{
    class CalculoVenda
    {
        #region Atributos

        decimal desconto,  unidade, total;
        int quantidade;

        #endregion

        #region Método construtor

        public CalculoVenda(decimal pd, decimal pu, int pqtd)
        {
            //parâmetros
            desconto = pd;
            unidade = pu;
            quantidade = pqtd;
        }

        #endregion

        #region Método para calcular o valor da venda

        public decimal Calcular()
        {
            total = (unidade * quantidade) - desconto;

            return total;
        }

        #endregion
    }
}
