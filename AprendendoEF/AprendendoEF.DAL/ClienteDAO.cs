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
        DataContext _context;

        public ClienteDAO()
        {
            _context = new DataContext();
        }

        public List<Cliente> Listar()
        {
            return _context.Clientes.ToList();
        }

        public Cliente Encontrar(int id)
        {
            return _context.Clientes.FirstOrDefault(cliente => cliente.ClienteId == id);
        }

        public void Inserir(Cliente cliente)
        {
            _context.Clientes.Add(cliente);
            _context.SaveChanges();
        }

        public void Editar(Cliente cliente)
        {
            _context.Clientes.Attach(cliente);
            _context.Entry(cliente).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Remover(int id)
        {
            var cliente = Encontrar(id);

            _context.Clientes.Attach(cliente);
            _context.Clientes.Remove(cliente);
            _context.SaveChanges();
        }
    }
}
