using GameDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Adapter
{
    public class MernisServiceAdapter : IMemberCheckService
    {
        public bool CheckIfRealPerson(Member member)
        {
            if (member.Name.Length >0 && member.LastName.Length > 0 && member.NationalityId.Length > 0 && member.DateOfBirth != null)
            {
               return true;
            }
            else
            {
               return false;
            }
            
        }
    }
}
