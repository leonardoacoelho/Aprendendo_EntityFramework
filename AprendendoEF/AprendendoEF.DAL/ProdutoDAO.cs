using AprendendoEF.DAL.Base;
using AprendendoEF.DAL.Context;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace AprendendoEF.DAL
{
    public class ProdutoDAO : BaseDAO<Produto>
    {
        public override List<Produto> Listar()
        {
            using (var context = new DataContext())
            {
                return context.Produtos.Include(x => x.GrupoProduto).ToList();
            }
        }

        public override Produto Encontrar(int id)
        {
            using (var context = new DataContext())
            {
                return context.Produtos.Include(x => x.GrupoProduto).FirstOrDefault(x => x.Id == id);
            }
        }

        public override void Inserir(Produto entidade)
        {
            using (var context = new DataContext())
            {
                context.Produtos.Add(entidade);
                context.SaveChanges();
            }
        }

        public override void Editar(Produto entidade)
        {
            using (var context = new DataContext())
            {
                context.Produtos.Attach(entidade);
                context.Entry(entidade).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
