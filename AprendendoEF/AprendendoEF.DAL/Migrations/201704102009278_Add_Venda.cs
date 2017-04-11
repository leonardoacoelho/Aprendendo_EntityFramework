namespace AprendendoEF.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Venda : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ItensVendas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Produto_Id = c.Int(nullable: false),
                        Quantidade = c.Double(nullable: false),
                        ValorUnitario = c.Double(nullable: false),
                        ValorTotal = c.Double(nullable: false),
                        Venda_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Produtos", t => t.Produto_Id)
                .ForeignKey("dbo.Vendas", t => t.Venda_Id, cascadeDelete: true)
                .Index(t => t.Produto_Id)
                .Index(t => t.Venda_Id);
            
            CreateTable(
                "dbo.Vendas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Cliente_Id = c.Int(nullable: false),
                        Data = c.DateTime(nullable: false),
                        Valor = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clientes", t => t.Cliente_Id)
                .Index(t => t.Cliente_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ItensVendas", "Venda_Id", "dbo.Vendas");
            DropForeignKey("dbo.Vendas", "Cliente_Id", "dbo.Clientes");
            DropForeignKey("dbo.ItensVendas", "Produto_Id", "dbo.Produtos");
            DropIndex("dbo.Vendas", new[] { "Cliente_Id" });
            DropIndex("dbo.ItensVendas", new[] { "Venda_Id" });
            DropIndex("dbo.ItensVendas", new[] { "Produto_Id" });
            DropTable("dbo.Vendas");
            DropTable("dbo.ItensVendas");
        }
    }
}
