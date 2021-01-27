using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Concrete
{
    public class SalesManager
    {

        private List<Sales> salesList = new List<Sales>();
        private List<BaseProperty> sCampaigns = new List<BaseProperty>();
        private List<BaseProperty> sGames = new List<BaseProperty>();

        //GameManager sGameManager = new GameManager();
        //CampaignManager sCampaignManager = new CampaignManager();

        
        private string GameName;
        private double gamePrice;



        public void Campaigns()
        {

            sCampaigns = CampaignManager.campaigns;

        }
        public void Games()
        {
            sGames = GameManager.games;

        }

        public double GameFound(int Id)
        {
            
            foreach (Game item in sGames)
            {
                if (Id == item.Id)
                {
                    GameName = item.Name;
                    return item.Price;
                }
            }
            return 0;
        }

        public void Sale(Sales sales)
        {
            Games();
            Campaigns();
            gamePrice = GameFound(sales.GameId);
            sales.PurchasePrice = gamePrice;
            foreach (Campaign item in sCampaigns)
            {
                if (GameName == item.CampaignGame)
                {
                    sales.PurchasePrice = gamePrice - item.Discount;
                    sales.CampaingId = item.Id;
                    break;
                }
            }
            salesList.Add(sales);
            Console.WriteLine("Sales was made!");
        }

        public void List()
        {
            foreach (Sales item in salesList)
            {
                Console.WriteLine("Id: " + item.Id + " // MemberId: " + item.MemberId + " // GameId: " + item.GameId + " // CampaingId: " + item.CampaingId + " // PurchasePrice: " + item.PurchasePrice);
            }
        }

        

    }
}
