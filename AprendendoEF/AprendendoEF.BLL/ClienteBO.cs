using AprendendoEF.BLL.Base;
using AprendendoEF.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendendoEF.BLL
{
    public class ClienteBO : BaseBO<Cliente, ClienteDAO>
    {
        public override void Salvar(Cliente entidade)
        {
            try
            {
                if ((string.IsNullOrEmpty(entidade.Nome)) || (string.IsNullOrEmpty(entidade.Email)))
                    throw new ArgumentNullException();

                base.Salvar(entidade);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
