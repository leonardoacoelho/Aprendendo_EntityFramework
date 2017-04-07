using System.Data.Entity.ModelConfiguration;

namespace AprendendoEF.DAL.Configurations
{
    public class ClienteConfig : EntityTypeConfiguration<Cliente>
    {
        public ClienteConfig()
        {
            ToTable("Clientes");
        }
    }
}
