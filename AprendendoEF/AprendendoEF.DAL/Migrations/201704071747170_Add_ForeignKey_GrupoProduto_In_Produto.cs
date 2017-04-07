namespace AprendendoEF.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_ForeignKey_GrupoProduto_In_Produto : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Produtos", "GrupoProduto_Id", "dbo.GruposProdutos");
            DropIndex("dbo.Produtos", new[] { "GrupoProduto_Id" });
            AlterColumn("dbo.Produtos", "GrupoProduto_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Produtos", "GrupoProduto_Id");
            AddForeignKey("dbo.Produtos", "GrupoProduto_Id", "dbo.GruposProdutos", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Produtos", "GrupoProduto_Id", "dbo.GruposProdutos");
            DropIndex("dbo.Produtos", new[] { "GrupoProduto_Id" });
            AlterColumn("dbo.Produtos", "GrupoProduto_Id", c => c.Int());
            CreateIndex("dbo.Produtos", "GrupoProduto_Id");
            AddForeignKey("dbo.Produtos", "GrupoProduto_Id", "dbo.GruposProdutos", "Id");
        }
    }
}
