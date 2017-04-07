using System.Data.Entity.ModelConfiguration;

namespace AprendendoEF.DAL.Configurations
{
    public class ProdutoConfig : EntityTypeConfiguration<Produto>
    {
        public ProdutoConfig()
        {
            ToTable("Produtos");
            HasRequired(p => p.GrupoProduto)
                .WithMany(g=> g.Produtos)
                .HasForeignKey(x => x.GrupoProduto_Id);
        }
    }
}
