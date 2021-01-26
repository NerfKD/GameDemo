using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Abstract
{
    public abstract class BaseProperty : IBaseProperty
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
