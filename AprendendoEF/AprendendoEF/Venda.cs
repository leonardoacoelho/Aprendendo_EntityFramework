﻿using AprendendoEF.Base;
using System;
using System.Collections.Generic;

namespace AprendendoEF
{
    public class Venda : BaseEntidade
    {
        public virtual Cliente Cliente { get; set; }

        public int Cliente_Id { get; set; }

        public DateTime Data { get; set; }

        public double Valor { get; set; }

        public virtual List<ItemVenda> Itens { get; set; }
    }
}