using AprendendoEF.BLL.Base;
using AprendendoEF.DAL;
using AprendendoEF.DAL.Context;
using AprendendoEF.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendendoEF.BLL
{
    public class UsuarioBO : BaseBO<Usuario, UsuarioDAO>
    {
        public override void Salvar(Usuario entidade)
        {
            if ((string.IsNullOrEmpty(entidade.Login)) || (string.IsNullOrEmpty(entidade.Senha)) || (string.IsNullOrEmpty(entidade.ConfirmaSenha)))
                throw new ArgumentNullException();

            if (!entidade.Senha.Equals(entidade.ConfirmaSenha))
                throw new ValoresNaoCoincidemException();

            base.Salvar(entidade);
        }

        protected override void Inserir(Usuario entidade)
        {
            var dao = new UsuarioDAO();
            var login = entidade.Login;
            var id = entidade.Id;
            var loginBd = dao.Encontrar(id).ToString();

            if (login == loginBd)
                throw new CadastroJaExistenteException();
            else
                base.Inserir(entidade);
        }

        public virtual Usuario Encontrar(string login)
        {
            try
            {
                var usuarioDAO = new UsuarioDAO();
                return usuarioDAO.Encontrar(login);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
