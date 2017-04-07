namespace AprendendoEF.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Grupo_Produto_in_Produto : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Produtos", "GrupoProduto_Id", c => c.Int());
            CreateIndex("dbo.Produtos", "GrupoProduto_Id");
            AddForeignKey("dbo.Produtos", "GrupoProduto_Id", "dbo.GruposProdutos", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Produtos", "GrupoProduto_Id", "dbo.GruposProdutos");
            DropIndex("dbo.Produtos", new[] { "GrupoProduto_Id" });
            DropColumn("dbo.Produtos", "GrupoProduto_Id");
        }
    }
}
