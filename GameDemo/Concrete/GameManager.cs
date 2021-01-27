using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Abstract
{
    public class GameManager : IBaseManager
    {
        public static List<BaseProperty> games = new List<BaseProperty>();
        public  void Add(BaseProperty baseProperty)
        {
            games.Add((Game)baseProperty);
            Console.WriteLine("Game added : " + baseProperty.Name);
        }

        public  void Delete(BaseProperty baseProperty)
        {
            games.Remove((Game)baseProperty);
            Console.WriteLine("Game deleted : " + baseProperty.Name);
        }

        public void List()
        {
            foreach (Game item in games)
            {
                Console.WriteLine("Id: " + item.Id + " // Name: " + item.Name + " // Price: " + item.Price + " // Type: " + item.Type);
            }
        }

        public List<BaseProperty> ListBack()
        {
            return games;
        }

        public   void Update(BaseProperty baseProperty)
        {
            foreach (Game item in games)
            {
                if (baseProperty.Id == item.Id)
                {
                    item.Name = ((Game)baseProperty).Name;
                    item.Price = ((Game)baseProperty).Price;
                    item.Type = ((Game)baseProperty).Type;
                    break;
                }
            }
            Console.WriteLine("Game updated : " + baseProperty.Name);
        }
    }
}
