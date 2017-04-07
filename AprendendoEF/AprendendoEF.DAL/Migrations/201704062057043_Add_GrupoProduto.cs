namespace AprendendoEF.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_GrupoProduto : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GruposProdutos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.GruposProdutos");
        }
    }
}
