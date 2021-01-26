using GameDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    public interface IBaseManager
    {
        void Add(BaseProperty baseProperty);
        void Update(BaseProperty baseProperty);
        void Delete(BaseProperty baseProperty);
        List<BaseProperty> List();
    }
}
