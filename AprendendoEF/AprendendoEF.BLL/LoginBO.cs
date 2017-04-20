namespace AprendendoEF.BLL
{
    public class LoginBO
    {
        public bool Logar(Usuario usuario)
        {
            var usuarioBo = new UsuarioBO();
            var usuarioBd = usuarioBo.Encontrar(usuario.Login);

            if (usuarioBd == null)
                return false;

            if (!usuarioBd.Senha.Equals(usuario.Senha))
                return false;
            
            return true;
        }
    }
}
