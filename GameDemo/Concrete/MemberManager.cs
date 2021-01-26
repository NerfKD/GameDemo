using GameDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    public class MemberManager : BaseManager
    {
        private List<Member> members = new List<Member>() { };
        private IMemberCheckService _memberCheckService;

        public MemberManager(IMemberCheckService memberCheckService)
        {
            _memberCheckService = memberCheckService;
        }
        public override void Add(BaseProperty baseProperty)
        {
            if (_memberCheckService.CheckIfRealPerson((Member)baseProperty))
            {
                base.Add((Member)baseProperty);
                members.Add((Member)baseProperty);
            }
            else
            {
                Console.WriteLine("Not a added member");
            }
            
        }

        public override void Delete(BaseProperty baseProperty)
        {
            base.Delete(baseProperty);
            members.Remove((Member)baseProperty);
            
        }

        public override void Update(BaseProperty baseProperty)
        {
            base.Update(baseProperty);
            foreach (var item in members)
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
            
        }

        public override List<Member> List()
        {
            return members;
        }
    }
}
