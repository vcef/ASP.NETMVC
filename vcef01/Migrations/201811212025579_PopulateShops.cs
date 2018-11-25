namespace vcef01.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateShops : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Shops (Nom,Image,Distance) VALUES ('Applause','https://www.kansai-airport.or.jp/sites/default/files/styles/tenant_image_main/public/2017-10/d060-main.jpg?itok=TUFezHbZ',1)" +
                "INSERT INTO Shops (Nom,Image,Distance) VALUES ('Lush','http://res.cloudinary.com/lush/image/upload/v1501839199/lush_website_uk/shops/hero/2017/08/swansea_shopfront.jpg',2)" +
                "INSERT INTO Shops (Nom,Image,Distance) VALUES ('Brick','https://endpoint915698.azureedge.net/globalassets/explore-legoland/beginning/uvid-4a0d99/the-brick-shop.jpg?w=1422&h=800&mode=crop&scale=both&quality=80&format=jpg',3)" +
                "INSERT INTO Shops (Nom,Image,Distance) VALUES ('body','https://www.america-retail.com/static//2018/09/The_Body_Shop.jpg',4)" +
                "INSERT INTO Shops (Nom,Image,Distance) VALUES ('Norway','https://media.newmindmedia.com/TellUs/image/?file=Norway-Shop__c_VisitOSLO_Christian-Rafn_1117979287.jpg&dh=533&dw=800&cropX=29&cropY=39&cropH=556&cropW=834',5)" +
                "INSERT INTO Shops (Nom,Image,Distance) VALUES ('Casino','https://www.marseille.aeroport.fr/var/mpaeroport/storage/images/media/images/boutiques/photo-casino-shop-2017/75961-1-fre-FR/photo-casino-shop-2017_full_shopping.jpg',6)");
        }
        
        public override void Down()
        {
        }
    }
}
