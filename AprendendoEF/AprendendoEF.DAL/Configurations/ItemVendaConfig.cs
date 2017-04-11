using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendendoEF.DAL.Configurations
{
    public class ItemVendaConfig : EntityTypeConfiguration<ItemVenda>
    {
        public ItemVendaConfig()
        {
            ToTable("ItensVendas");

            HasRequired(i => i.Produto)
                .WithMany()
                .HasForeignKey(x => x.Produto_Id);

            HasRequired(i => i.Venda)
                .WithMany(v => v.Itens)
                .HasForeignKey(x => x.Venda_Id);
        }
    }
}
