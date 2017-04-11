namespace AprendendoEF.DAL.Context
{
    using Configurations;
    using System.Data.Entity;

    public class DataContext : DbContext
    {
        public DataContext()
            : base("name=DataContext")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new ClienteConfig());
            modelBuilder.Configurations.Add(new ProdutoConfig());
            modelBuilder.Configurations.Add(new GrupoProdutoConfig());
            modelBuilder.Configurations.Add(new ItemVendaConfig());
            modelBuilder.Configurations.Add(new VendaConfig());
        }

        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Produto> Produtos { get; set; }
        public virtual DbSet<GrupoProduto> GruposProdutos { get; set; }
        public virtual DbSet<Venda> Vendas { get; set;}
        public virtual DbSet<ItemVenda> ItensVendas { get; set; }

    }
}