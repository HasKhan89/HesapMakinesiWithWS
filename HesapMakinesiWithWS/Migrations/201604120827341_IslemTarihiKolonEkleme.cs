namespace HesapMakinesiWithWS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IslemTarihiKolonEkleme : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CalculatorIslemler", "IslemTarihi", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.CalculatorIslemler", "IslemTarihi");
        }
    }
}
