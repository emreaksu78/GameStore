using GameStoreDemo.Abstract;
using GameStoreDemo.Adapters;
using GameStoreDemo.Concrete;
using GameStoreDemo.Entities;
using System;

namespace GameStoreDemo
{
    class Program
    {
        static void Main(string[] args)
        {
           
            BasePlayerManager playerManager1 = new SteamPlayerManager(new PlayerCheckManager());
            playerManager1.Register(new Player() { DateOfBirth = new DateTime(1995, 12, 11).Year, PlayerId = 0, FirstName = "Emre", LastName = "Aksu", NationalityId = 22233344555});
            playerManager1.UpdateInformation(new Player() { DateOfBirth = new DateTime(1995, 12, 11).Year, PlayerId = 0, FirstName = "Emre", LastName = "Aksu", NationalityId = 22233344555});
            playerManager1.DeleteAccount(new Player() { DateOfBirth = new DateTime(1995, 12, 11).Year, PlayerId = 0, FirstName = "Emre", LastName = "Aksu", NationalityId = 22233344555 });

            Player player1 = new Player()
            {
                PlayerId = 10,
                FirstName = "Emre",
                LastName = "Aksu",
                DateOfBirth = new DateTime(1995, 12, 11).Year,
                NationalityId = 22233344555

            };

            Game game1 = new Game()
            {
                GameId = 1,
                Name = "COD",
                Price = 100
            };

            Campaign campaign1 = new Campaign()
            {
                CampaignId = 0,
                Name = "Discount on the weekend",
                Discount = 30
            };

            GameManager gameManager = new GameManager();
            gameManager.Save(game1);
            gameManager.Update(game1);
            gameManager.Delete(game1);

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);
            campaignManager.Update(campaign1);
            campaignManager.Delete(campaign1);

            SaleManager saleManager = new SaleManager();
            saleManager.DiscountSend(player1,game1,campaign1);
            saleManager.Sale(player1,game1,campaign1);
            
            GameManager gameService = new GameManager();
            gameService.Save(game1) ;
        
        }   
    }
}
