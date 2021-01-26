using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Abstract
{
    public interface IMemberCheckService
    {
        bool CheckIfRealPerson(Member member);
    }
}
