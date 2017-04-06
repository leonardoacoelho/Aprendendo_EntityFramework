using AprendendoEF.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendendoEF.BLL
{
    public class ClienteBO
    {
        ClienteDAO dao;

        public ClienteBO()
        {
            dao = new ClienteDAO();
        }

        private void Inserir(Cliente cliente)
        {
            try
            {
                dao.Inserir(cliente);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Editar(Cliente cliente)
        {
            try
            {
                dao.Editar(cliente);
            }
            catch (Exception)
            {

                throw;
            }

        }

        public void Salvar(Cliente cliente)
        {
            try
            {
                if ((string.IsNullOrEmpty(cliente.Nome)) || (string.IsNullOrEmpty(cliente.Email)))
                    throw new ArgumentNullException();

                if (cliente.Id == 0)
                    Inserir(cliente);
                else
                    Editar(cliente);


            }
            catch (Exception)
            {
                throw;
            }
        }

        public Cliente Encontrar(int id)
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

        public List<Cliente> Listar()
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

        public void Remover(int id)
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
