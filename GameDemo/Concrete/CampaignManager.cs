using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Abstract
{
    public class CampaignManager : IBaseManager
    {
        public static List<BaseProperty> campaigns = new List<BaseProperty>();
        public  void Add(BaseProperty baseProperty)
        {
            campaigns.Add((Campaign)baseProperty);
            Console.WriteLine("Campaign added : " + baseProperty.Name);
        }

        public  void Delete(BaseProperty baseProperty)
        {
            campaigns.Remove((Campaign)baseProperty);
            Console.WriteLine("Campaign deleted : " + baseProperty.Name);
        }

        public void List()
        {
            foreach (Campaign item in campaigns)
            {
                Console.WriteLine("Id: " + item.Id + " // Name: " + item.Name + " // Discount: " + item.Discount + " // CampaignGame: " + item.CampaignGame);
            }
        }

        public List<BaseProperty> ListBack()
        {
            return campaigns;
        }

        public  void Update(BaseProperty baseProperty)
        {
            foreach (Campaign item in campaigns)
            {
                if (baseProperty.Id == item.Id)
                {
                    item.Name = ((Campaign)baseProperty).Name;
                    item.Discount = ((Campaign)baseProperty).Discount;
                    item.CampaignGame = ((Campaign)baseProperty).CampaignGame;
                    break;
                }
            }
            Console.WriteLine("Campaign updated : " + baseProperty.Name);
        }
    }
}
