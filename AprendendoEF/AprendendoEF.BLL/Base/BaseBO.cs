using AprendendoEF.DAL.Interfaces;
using AprendendoEF.Interfaces;
using System;
using System.Collections.Generic;

namespace AprendendoEF.BLL.Base
{
    public class BaseBO<T, TDAO> 
        where T : class, IBaseEntidade 
        where TDAO : class, IBaseDAO<T>, new()
    {
        TDAO dao;

        public BaseBO()
        {
            dao = new TDAO();
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
