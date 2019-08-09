using System;
using System.Collections.Generic;
using System.Text;

namespace EstudoClasses
{
    class Estoque
    {
        public String Nome;
        public double Preco;
        public int Qtd;

        public double ValorTotalEstoque()
        {
            return Qtd * Preco;

        }
        public void AdicionarProduto(int qtd)
        {
            Qtd += qtd;
        }
        public void RemoverProduto(int qtd)
        {
            Qtd -= qtd;
        }

        public override string ToString()
        {
            return String.Format("{0}, R$ {1} Qtd: {2}. Valor total R$ {3}", Nome, Preco, Qtd, ValorTotalEstoque());
        }
    }
}
