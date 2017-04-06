using AprendendoEF.DAL.Base;
using AprendendoEF.DAL.Interfaces;
using AprendendoEF.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendendoEF.BLL.Base
{
    public class BaseBO<T> 
        where T : class, IBaseEntidade 
    {
        BaseDAO<T> dao;

        public BaseBO()
        {
            dao = new BaseDAO<T>();
        }

        protected virtual void Inserir(T entidade)
        {
            try
            {
                dao.Inserir(entidade);
            }
            catch (Exception)
            {

                throw;
            }
        }

        protected virtual void Editar(T entidade)
        {
            try
            {
                dao.Editar(entidade);
            }
            catch (Exception)
            {

                throw;
            }

        }

        public virtual void Salvar(T entidade)
        {
            try
            {
                if (entidade.Id == 0)
                    Inserir(entidade);
                else
                    Editar(entidade);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public virtual T Encontrar(int id)
        {
            try
            {
                return dao.Encontrar(id);

            }
            catch (Exception)
            {

                throw;
            }
        }

        public virtual List<T> Listar()
        {
            try
            {
                return dao.Listar();

            }
            catch (Exception)
            {

                throw;
            }
        }

        public virtual void Remover(int id)
        {
            try
            {
                dao.Remover(id);

            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
