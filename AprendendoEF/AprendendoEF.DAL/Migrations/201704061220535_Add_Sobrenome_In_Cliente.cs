namespace AprendendoEF.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Sobrenome_In_Cliente : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clientes", "Sobrenome", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Clientes", "Sobrenome");
        }
    }
}
