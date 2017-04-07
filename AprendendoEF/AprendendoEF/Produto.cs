using AprendendoEF.Base;

namespace AprendendoEF
{
    public class Produto : BaseEntidade
    {
        public string Descricao { get; set; }

        public double Valor { get; set; }

        public GrupoProduto GrupoProduto { get; set; }

        public int GrupoProduto_Id { get; set; }
    }
}
