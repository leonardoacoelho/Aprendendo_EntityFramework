using System.Data.Entity.ModelConfiguration;

namespace AprendendoEF.DAL.Configurations
{
    public class GrupoProdutoConfig : EntityTypeConfiguration<GrupoProduto>
    {
        public GrupoProdutoConfig()
        {
            ToTable("GruposProdutos");
        }
    }
}
