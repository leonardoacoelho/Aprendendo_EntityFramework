namespace AprendendoEF.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Item_to_ItemVenda : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ItensVendas", "Item", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ItensVendas", "Item");
        }
    }
}
