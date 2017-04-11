﻿using AprendendoEF.Base;

namespace AprendendoEF
{
    public class ItemVenda : BaseEntidade
    {
        public virtual Produto Produto { get; set; }

        public int Produto_Id { get; set; }

        public double Quantidade { get; set; }

        public double ValorUnitario { get; set; }

        public double ValorTotal { get; set; }

        public virtual Venda Venda { get; set; }

        public int Venda_Id { get; set; }
    }
}