using System.Data.Entity.ModelConfiguration;

namespace AprendendoEF.DAL.Configurations
{
    public class UsuarioConfig : EntityTypeConfiguration<Usuario>
    {
        public UsuarioConfig()
        {
            ToTable("Usuarios");

            Ignore(x => x.ConfirmaSenha);
        }
    }
}
