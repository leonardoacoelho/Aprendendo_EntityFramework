using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendendoEF.DAL
{
    public class ClienteDAO
    {
        public List<Cliente> Listar()
        {
            //Quando passa pela ultima chave mata o objeto, limpa a memoria
            using (var _context = new DataContext())
            {
                return _context.Clientes.ToList();
            }
        }

        public Cliente Encontrar(int id)
        {
            using (var _context = new DataContext())
            {
                return _context.Clientes.FirstOrDefault(x => x.ClienteId == id);
            }
        }

        public void Inserir(Cliente cliente)
        {
            using (var _context = new DataContext())
            {
                _context.Clientes.Add(cliente);
                _context.SaveChanges();
            }
        }

        public void Editar(Cliente cliente)
        {
            using (var _context = new DataContext())
            {
                _context.Clientes.Attach(cliente);
                _context.Entry(cliente).State = EntityState.Modified;
                _context.SaveChanges();
            }
        }

        public void Remover(int id)
        {
            using (var _context = new DataContext())
            {
                var cliente = Encontrar(id);

                _context.Clientes.Attach(cliente);
                _context.Clientes.Remove(cliente);
                _context.SaveChanges();
            }
        }
    }
}
