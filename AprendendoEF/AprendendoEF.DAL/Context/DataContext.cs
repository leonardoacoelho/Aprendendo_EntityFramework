namespace AprendendoEF.DAL.Context
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class DataContext : DbContext
    {
        public DataContext()
            : base("name=DataContext")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Cliente>().ToTable("Clientes");
            modelBuilder.Entity<Produto>().ToTable("Produtos");
            modelBuilder.Entity<GrupoProduto>().ToTable("GruposProdutos");
        }

        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Produto> Produtos { get; set; }
        public virtual DbSet<GrupoProduto> GruposProdutos { get; set; }

    }
}