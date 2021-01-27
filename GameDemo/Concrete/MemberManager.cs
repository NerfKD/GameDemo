using GameDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    public class MemberManager : IBaseManager
    {   
        private IMemberCheckService _memberCheckService;
        List<Member> members = new List<Member>();
        public MemberManager(IMemberCheckService memberCheckService)
        {
            _memberCheckService = memberCheckService;
        }

       

        public  void Add(BaseProperty baseProperty)
        {
            if (_memberCheckService.CheckIfRealPerson((Member)baseProperty))
            {
                members.Add((Member)baseProperty);
                Console.WriteLine("Member added : " + baseProperty.Name);
            }
            else
            {
                Console.WriteLine("Not a added member");
            }
            
        }

        public  void Delete(BaseProperty baseProperty)
        {  
            members.Remove((Member)baseProperty);
            Console.WriteLine("Member deleted : " + baseProperty.Name);
        }

        public  void List()
        {
            foreach (Member item in members)
            {
                Console.WriteLine("Id: " + item.Id + " // Name: " + item.Name + " // LastName: " + item.LastName);
            }
        }

        


        public  void Update(BaseProperty baseProperty)
        {
            foreach (Member item in members)
            {
                if (baseProperty.Id == item.Id)
                {
                    item.Name = ((Member)baseProperty).Name;
                    item.LastName = ((Member)baseProperty).LastName;
                    item.NationalityId = ((Member)baseProperty).NationalityId;
                    item.NickName = ((Member)baseProperty).NickName;
                    item.DateOfBirth = ((Member)baseProperty).DateOfBirth;
                    break;
                }
            }
            Console.WriteLine("Member updated : " + baseProperty.Name);
        }

    }
}
