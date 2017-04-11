using System.Data.Entity.ModelConfiguration;

namespace AprendendoEF.DAL.Configurations
{
    public class VendaConfig : EntityTypeConfiguration<Venda>
    {
        public VendaConfig()
        {
            ToTable("Vendas");

            HasRequired(v => v.Cliente)
                .WithMany()
                .HasForeignKey(x => x.Cliente_Id);
        }
    }
}
