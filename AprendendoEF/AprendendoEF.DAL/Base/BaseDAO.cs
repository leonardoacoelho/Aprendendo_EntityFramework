using AprendendoEF.DAL.Context;
using AprendendoEF.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendendoEF.DAL.Base
{
    public class BaseDAO<T> where T : class, IBaseEntidade
    {
        public virtual List<T> Listar()
        {
            //Quando passa pela ultima chave mata o objeto, limpa a memoria
            using (var _context = new DataContext())
            {
                var dbSet = _context.Set<T>();

                return dbSet.ToList();
            }
        }

        public virtual T Encontrar(int id)
        {
            using (var _context = new DataContext())
            {
                var dbSet = _context.Set<T>();
                return dbSet.FirstOrDefault(x => x.Id == id);
            }
        }

        public virtual void Inserir(T entidade)
        {
            using (var _context = new DataContext())
            {
                var dbSet = _context.Set<T>();
                dbSet.Add(entidade);
                _context.SaveChanges();
            }
        }

        public virtual void Editar(T entidade)
        {
            using (var _context = new DataContext())
            {
                var dbSet = _context.Set<T>();
                dbSet.Attach(entidade);
                _context.Entry(entidade).State = EntityState.Modified;
                _context.SaveChanges();
            }
        }

        public virtual void Remover(int id)
        {
            using (var _context = new DataContext())
            {
                var entidade = Encontrar(id);

                var dbSet = _context.Set<T>();
                dbSet.Attach(entidade);
                dbSet.Remove(entidade);
                _context.SaveChanges();
            }
        }
    }
}
