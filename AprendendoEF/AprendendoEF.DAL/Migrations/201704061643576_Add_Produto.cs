namespace AprendendoEF.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Produto : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Produtos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                        Valor = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            DropPrimaryKey("dbo.Clientes");
            DropColumn("dbo.Clientes", "ClienteId");

            AddColumn("dbo.Clientes", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Clientes", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Clientes");
            DropColumn("dbo.Clientes", "Id");

            AddColumn("dbo.Clientes", "ClienteId", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Clientes", "ClienteId");

            DropTable("dbo.Produtos");
        }
    }
}
