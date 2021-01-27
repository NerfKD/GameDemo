using GameDemo.Abstract;
using GameDemo.Adapter;
using GameDemo.Concrete;
using GameDemo.Entities;
using System;
using System.Collections.Generic;

namespace GameDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            BaseProperty member = new Member() { Id = 1, Name = "Kerim", LastName = "Dinçer", NickName = "Nerf KD", DateOfBirth = new DateTime(1992, 9, 6), NationalityId = "11522366578" };
            BaseProperty member2 = new Member() { Id = 2, Name = "Emre", LastName = "Dinçer", NickName = "Nerf ED", DateOfBirth = new DateTime(1991, 4, 1), NationalityId = "11522333556" };
            IBaseManager memberManager = new MemberManager(new MernisServiceAdapter());
            memberManager.Add(member);
            memberManager.Add(member2);
            memberManager.List();
            ((Member)member).LastName = "Dinç";
            ((Member)member).Name = "Ker";
            memberManager.Update(member);
            memberManager.List();
            memberManager.Delete(member2);
            memberManager.List();


            BaseProperty game = new Game() { Id = 1, Name = "GTA", Price = 350, Type = "RP" };
            BaseProperty game2 = new Game() { Id = 2, Name = "AC", Price = 250, Type = "AC" };
            BaseProperty game3 = new Game() { Id = 3, Name = "PUBG", Price = 90, Type = "BR" };
            IBaseManager gameManager = new GameManager();
            gameManager.Add(game);
            gameManager.Add(game2);
            gameManager.Add(game3);
            gameManager.List();
            ((Game)game).Name = "GTAV";
            gameManager.Update(game);
            gameManager.List();
            gameManager.Delete(game3);
            gameManager.List();


            BaseProperty campaign = new Campaign() { Id = 1, Name = "GTA indirim", CampaignGame = "GTA", Discount = 50 };
            BaseProperty campaign2 = new Campaign() { Id = 2, Name = "AC indirim", CampaignGame = "AC", Discount = 50 };
            IBaseManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign);
            campaignManager.Add(campaign2);
            campaignManager.List();
            ((Campaign)campaign).Name = "GTAV indirim";
            ((Campaign)campaign).CampaignGame = "GTAV";
            campaignManager.Update(campaign);
            campaignManager.List();
            campaignManager.Delete(campaign2);
            campaignManager.List();

            Sales sale = new Sales() { Id = 1,  MemberId = 1, GameId = 1,  CampaingId = 0, PurchasePrice = 0 };
            Sales sale2 = new Sales() { Id = 2, MemberId = 1, GameId = 2, CampaingId = 0, PurchasePrice = 0 };
            SalesManager salesManager = new SalesManager();
            salesManager.Sale(sale);
            salesManager.Sale(sale2);
            salesManager.List();

            Console.ReadLine();

        }
    }
}
