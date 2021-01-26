using GameDemo.Abstract;
using GameDemo.Adapter;
using GameDemo.Entities;
using System;

namespace GameDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseProperty member = new Member() { Id = 1, Name = "Kerim", LastName = "Dinçer", NickName = "Nerf KD", DateOfBirth = new DateTime(1992, 9, 6), NationalityId = "11522366578" };
            BaseManager memberManager = new MemberManager(new MernisServiceAdapter());
            memberManager.Add(member);

            ((Member)member).LastName = "Dinç";
            memberManager.Update(member);
            Console.WriteLine(((Member)member).LastName);
            memberManager.Delete(member);
            

            BaseProperty game = new Game() { Id = 1, Name = "GTA", Price = 350, Type = "RP" };
            BaseManager gameManager = new GameManager();
            gameManager.Add(game);
            gameManager.Update(game);
            gameManager.Delete(game);

            BaseProperty campaign = new Campaign { Id = 1, Name = "GTA indirim", CampaignGame = "GTA", Discount = 50 };
            BaseManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign);
            campaignManager.Update(campaign);
            campaignManager.Delete(campaign);

        }
    }
}
