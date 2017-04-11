using AprendendoEF.DAL.Context;
using AprendendoEF.DAL.Interfaces;
using AprendendoEF.Interfaces;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace AprendendoEF.DAL.Base
{
    /// <summary>
    /// Cria uma instância da classe de acesso a dados conforme o tipo passado em T
    /// </summary>
    /// <typeparam name="T">Tipo da ENTIDADE</typeparam>
    public class BaseDAO<T> : IBaseDAO<T> where T : class, IBaseEntidade
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
