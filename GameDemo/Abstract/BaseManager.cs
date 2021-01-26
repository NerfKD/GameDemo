using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Abstract
{
    public abstract class BaseManager : IBaseManager
    {
        public virtual void Add(BaseProperty baseProperty)
        {
            Console.WriteLine("Saved to DB :" + baseProperty.Name);
        }

        public virtual void Delete(BaseProperty baseProperty)
        {
            Console.WriteLine("Deleted to DB :" + baseProperty.Name);
        }

        public List<Member> List()
        {
            Console.WriteLine("Listed to Screen");
        }

        public virtual void Update(BaseProperty baseProperty)
        {
            Console.WriteLine("Updated to DB :" + baseProperty.Name);
        }
    }
}
